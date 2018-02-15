using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automat.Model;
using Automat.View;


namespace Automat.Controller
{
    public class PersonController
    {
        public PersonController(int? dossierId)
        {
            this.dossierId = dossierId;

            getPersonList();
            personViewForm = new PersonViewForm();


            this.personViewForm.selectWithID = showWithID;
            this.personViewForm.save = save;
            this.personViewForm.saveNew = saveNew;
            this.personViewForm.delete = delete;


            this.personViewForm.setPersonList(this.personList, "naam", "Id");
        }

        



        public void showView()
        {
            if (personViewForm != null)
            {
                personViewForm.Show();
            }

        }


        public void showWithID(int id)
        {
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Persoon persoon = dossierContext.personen.SingleOrDefault(c => c.Id == id);
                if (persoon != null)
                {
                    this.personViewForm.setPerson(persoon.Id, persoon.naam, persoon.email, persoon.organisatie, persoon.departement, persoon.RowVersion);
                }
            }
        }

        public int save(int id, string name, string email, string organisation, string departement, byte[] rowVersion)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Persoon persoon = dossierContext.personen.SingleOrDefault(c => c.Id == id);

                if (persoon == null)
                {
                   // this.overviewForm.setStatusText("Entry was deleted by another user.");
                    return saveNew(out id, name, email, organisation, departement);
                }
                else
                {
                    if (Database.DossierContext.ByteArrayCompare(rowVersion, persoon.RowVersion))
                    {
                        persoon.naam = name;
                        persoon.email = email;
                        persoon.organisatie = organisation;
                        persoon.departement = departement;

                        result = dossierContext.SaveChanges();

                        getPersonList();
                        //this.personList = dossierContext.personen.ToList();
                        this.personViewForm.setPersonList(this.personList, "name", "Id");
                    }
                    else
                    {
                      //  this.overviewForm.setStatusText("Entry was modified by another user.");
                    }
                }
            }
            return result;
        }



        public int saveNew(out int id, string name, string email, string organisation, string departement)
        {
            int result = 0;
            Persoon persoon = new Persoon();
            persoon.naam = name;
            persoon.email = email;
            persoon.organisatie = organisation;
            persoon.departement = departement;

            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                dossierContext.personen.Add(persoon);
                result = dossierContext.SaveChanges();

                getPersonList();
                //this.personList = dossierContext.personen.ToList();
                this.personViewForm.setPersonList(this.personList, "name", "Id");
                if (result > 0)
                {
                    id = persoon.Id;
                }
                else
                {
                    id = -1;
                }
            }
            return result;

        }


        public int delete(int id)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Persoon persoon = dossierContext.personen.Where(c => c.Id == id).First(); ;
                dossierContext.personen.Remove(persoon);
                result = dossierContext.SaveChanges();

                getPersonList();
                //this.personList = dossierContext.personen.ToList();
                this.personViewForm.setPersonList(this.personList, "name", "Id");
            }
            return result;
        }


        public string getNamesAsString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Persoon p in personList)
            {
                sb.Append(p.naam);
                sb.Append(", ");
            }

            if (sb.Length > 2) // At least one name was present. 
            {
                // return the string, minus the trailing ", ".
                return sb.ToString(0, sb.Length - 2);
            }
            else // the personList was empty.
            {
                return "Geen contactpersonen";
            }

        }


        private void getPersonList()
        {
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                if (this.dossierId == null)
                {
                    this.personList = dossierContext.personen.ToList();
                }
                else
                {
                    this.personList = (from t3 in dossierContext.dossierPersoon
                                       where t3.dossierId == this.dossierId
                                       from t2 in dossierContext.personen
                                       where t2.Id == t3.persoonId
                                       select t2).ToList();
                }
            }
        }


        public List<Tuple<string, int>> getNameTuples()
        {
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();

            foreach(Persoon p in personList)
            {
                tuples.Add(new Tuple<string, int>(p.naam, p.Id));
            }

            return tuples;
        }


        int? dossierId;
        List<Persoon> personList;
        PersonViewForm personViewForm;


        
    }
}
