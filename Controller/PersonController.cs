/*  Notes:
 *
 * */

namespace Automat.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Automat.Model;
    using Automat.View;

    public class PersonController
    {
        private int? dossierId;
        private List<Persoon> personList;
        private PersonViewForm personViewForm;
        private List<int> personsToAdd = new List<int>();
        private int modifiedCount = 0;

        public PersonController(int? dossierId)
        {
            this.dossierId = dossierId;

            this.GetPersonList();
            this.personViewForm = new PersonViewForm();

            // Configure delegates
            this.personViewForm.SelectWithID = this.ShowWithID;
            this.personViewForm.Save = this.Save;
            this.personViewForm.SaveNew = this.SaveNew;
            this.personViewForm.Delete = this.Delete;
            this.personViewForm.SetPersonList(this.personList, "naam", "Id");
        }

        public void ShowView()
        {
            if (this.personViewForm != null)
            {
                this.personViewForm.Show();
            }
        }

        public void ShowWithID(int id)
        {
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Persoon persoon = dossierContext.Personen.SingleOrDefault(c => c.Id == id);
                if (persoon != null)
                {
                    this.personViewForm.SetPerson(persoon.Id, persoon.Naam, persoon.Email, persoon.Organisatie, persoon.Departement, persoon.RowVersion);
                }
            }
        }

        public int Save(int id, string name, string email, string organisation, string departement, byte[] rowVersion)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Persoon persoon = dossierContext.Personen.SingleOrDefault(c => c.Id == id);

                if (persoon == null)
                {
                    return this.SaveNew(out id, name, email, organisation, departement);
                }
                else
                {
                    if (Database.DossierContext.ByteArrayCompare(rowVersion, persoon.RowVersion))
                    {
                        persoon.Naam = name;
                        persoon.Email = email;
                        persoon.Organisatie = organisation;
                        persoon.Departement = departement;

                        FluentValidation.Results.ValidationResult validationResult = new Model.PersoonValidator().Validate(persoon);

                        if (validationResult.IsValid)
                        {
                            result = dossierContext.SaveChanges();
                        }
                        else
                        {
                            Model.PersoonValidator.DisplayErrorMessage(validationResult);
                        }

                        this.GetPersonList();

                        this.personViewForm.SetPersonList(this.personList, "name", "Id");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Persoon werd gewijzigd door een andere gebruiker.", "Persoon gewijzigd", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }

            return result;
        }

        public int SaveNew(out int id, string name, string email, string organisation, string departement)
        {
            int result = 0;
            id = -1;

            Persoon persoon = new Persoon();
            persoon.Naam = name;
            persoon.Email = email;
            persoon.Organisatie = organisation;
            persoon.Departement = departement;

            FluentValidation.Results.ValidationResult validationResult = new Model.PersoonValidator().Validate(persoon);

            if (validationResult.IsValid)
            {
                using (Database.DossierContext dossierContext = new Database.DossierContext())
                {
                    dossierContext.Personen.Add(persoon);
                    result = dossierContext.SaveChanges();

                    this.GetPersonList();

                    this.personViewForm.SetPersonList(this.personList, "name", "Id");
                    if (result > 0)
                    {
                        id = persoon.Id;
                    }
                    else
                    {
                        id = -1;
                    }
                }
            }
            else
            {
                Model.PersoonValidator.DisplayErrorMessage(validationResult);
            }

            return result;
        }

        public int Delete(int id)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Persoon persoon = dossierContext.Personen.Where(c => c.Id == id).First();
                dossierContext.Personen.Remove(persoon);
                result = dossierContext.SaveChanges();

                this.GetPersonList();

                this.personViewForm.SetPersonList(this.personList, "name", "Id");
            }

            return result;
        }

        public string GetNamesAsString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Persoon p in this.personList)
            {
                sb.Append(p.Naam);
                sb.Append(", ");
            }

            // At least one name was present.
            if (sb.Length > 2)
            {
                // return the string, minus the trailing ", ".
                return sb.ToString(0, sb.Length - 2);
            }
            else
            {
                return "Geen contactpersonen";
            }
        }

        public List<Tuple<string, int>> GetNameTuples()
        {
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();

            foreach (Persoon p in this.personList)
            {
                tuples.Add(new Tuple<string, int>(p.Naam, p.Id));
            }

            return tuples;
        }

        public int PersistLinkedPersonList(List<Tuple<string, int>> linkedPersons)
        {
            List<int> personsToRemove = new List<int>();
            foreach (Persoon stored_p in this.personList)
            {
                bool found = false;
                foreach (Tuple<string, int> new_p in linkedPersons)
                {
                    if (stored_p.Id == new_p.Item2)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    personsToRemove.Add(stored_p.Id);
                }
            }

            foreach (Tuple<string, int> new_p in linkedPersons)
            {
                bool found = false;
                foreach (Persoon stored_p in this.personList)
                {
                    if (stored_p.Id == new_p.Item2)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    this.personsToAdd.Add(new_p.Item2);
                }
            }

            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                foreach (int p in personsToRemove)
                {
                    DossierPersoon dp = dossierContext.DossierPersoon.SingleOrDefault(c => c.PersoonId == p && c.DossierId == this.dossierId);
                    if (dp != null)
                    {
                        dossierContext.DossierPersoon.Remove(dp);
                    }
                }

                foreach (int p in this.personsToAdd)
                {
                    if (this.dossierId != null)
                    {
                        DossierPersoon dp = new DossierPersoon();

                        dp.DossierId = (int)this.dossierId;
                        dp.PersoonId = p;

                        dossierContext.DossierPersoon.Add(dp);
                    }
                }

                this.modifiedCount = dossierContext.SaveChanges();
            }

            return this.modifiedCount;
        }

        private void GetPersonList()
        {
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                if (this.dossierId == null)
                {
                    this.personList = dossierContext.Personen.ToList();
                }
                else
                {
                    this.personList = (from t3 in dossierContext.DossierPersoon
                                       where t3.DossierId == this.dossierId
                                       from t2 in dossierContext.Personen
                                       where t2.Id == t3.PersoonId
                                       select t2).ToList();
                }
            }
        }
    }
}
