﻿/*  Notes:
 *
 * */

namespace Automat.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Automat.Model;
    using Automat.View;

    public class OverviewController
    {
        private OverviewForm overviewForm;
        private List<Dossier> dossierList;
        private Form parent;

        public OverviewController(Form parent)
        {
            this.parent = parent;

            this.overviewForm = new OverviewForm();
            this.overviewForm.SelectWithID = this.ShowWithID;
            this.overviewForm.SaveDossier = this.SaveDossier;
            this.overviewForm.SaveNewDossier = this.SaveNewDossier;
            this.overviewForm.DeleteDossier = this.DeleteDossier;

            this.overviewForm.ShowPersonFormValue = this.ShowPersonForm;
            this.overviewForm.ExitApplication = this.ExitApplication;
            this.overviewForm.RefreshDossierList = this.RefreshDossierList;
            this.overviewForm.GetAllPersons = this.GetAllPersons;
            this.overviewForm.PersistLinkedPersonList = this.PersistLinkedPersonList;
            this.overviewForm.GetAllProcedureNames = this.GetAllProcedures;
            this.RefreshDossierList(false);
        }

        public string LastError { get; set; }

        public void RefreshDossierList(bool showArchived)
        {
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                if (!showArchived)
                {
                    this.dossierList = dossierContext.Dossiers.Where(c => c.IsGearchiveerd == false).OrderBy(s => s.DossierNummer).ToList();
                }
                else
                {
                    this.dossierList = dossierContext.Dossiers.OrderBy(s => s.DossierNummer).ToList();
                }

                this.overviewForm.SetDossierList(this.dossierList, "Name", "Id");
            }
        }

        public void ShowView()
        {
            if (this.overviewForm != null)
            {
                this.overviewForm.Show();
            }
        }

        public System.Windows.Forms.Form GetView()
        {
            if (this.overviewForm != null)
            {
                return this.overviewForm;
            }
            else
            {
                return null;
            }
        }

        public void ShowWithID(int id)
        {
            Dossier dossier = null;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                dossier = dossierContext.Dossiers.SingleOrDefault(c => c.Id == id);
            }

            if (dossier != null)
            {
                Controller.PersonController personController = new Controller.PersonController(id);

                List<Tuple<string, int>> contactpersonen = personController.GetNameTuples();
                string procedure = Automat.Rules.DossierRules.GetProcedureName(dossier.DossierProcedure);
                this.overviewForm.Setdossier(dossier.Id, dossier.DossierNummer, dossier.DossierTitel, dossier.DossierStandvanzaken, dossier.IsGearchiveerd, contactpersonen, dossier.DossierLinkToFiles, procedure, dossier.RowVersion);
            }
        }

        public int SaveDossier(int id, string nummer, string titel, string stavaza, bool isArchived, string linkTofiles, string procedure, byte[] rowVersion)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Dossier dossier = dossierContext.Dossiers.SingleOrDefault(c => c.Id == id);

                // the dossier is delete by another user?
                if (dossier == null)
                {
                    this.overviewForm.SetStatusText("Entry was deleted by another user.");
                    return this.SaveNewDossier(out id, nummer, titel, stavaza);
                }
                else
                {
                    if (Database.DossierContext.ByteArrayCompare(rowVersion, dossier.RowVersion))
                    {
                        dossier.DossierNummer = nummer;
                        dossier.DossierTitel = titel;
                        dossier.DossierStandvanzaken = stavaza;
                        dossier.IsGearchiveerd = isArchived;
                        if (linkTofiles != string.Empty)
                        {
                            dossier.DossierLinkToFiles = linkTofiles;
                        }
                        else
                        {
                            dossier.DossierLinkToFiles = Automat.Rules.DossierRules.GetFileLocation(nummer);
                        }

                        dossier.DossierProcedure = Automat.Rules.DossierRules.GetProcedureID(procedure);

                        FluentValidation.Results.ValidationResult validationResult = new DossierValidator().Validate(dossier);

                        if (validationResult.IsValid)
                        {
                            result = dossierContext.SaveChanges();
                        }
                        else
                        {
                            DossierValidator.DisplayErrorMessage(validationResult);
                        }

                        this.RefreshDossierList(this.overviewForm.IsShowingArchivedItems());
                    }
                    else
                    {
                        this.overviewForm.SetStatusText("Entry was modified by another user.");
                    }
                }
            }

            return result;
        }

        public int SaveNewDossier(out int id, string nummer, string titel, string stavaza)
        {
            int result = 0;
            id = -1;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Dossier dossier = new Dossier();
                dossier.DossierNummer = nummer;
                dossier.DossierTitel = titel;
                dossier.DossierStandvanzaken = stavaza;
                dossier.IsGearchiveerd = false;
                dossier.DossierLinkToFiles = Automat.Rules.DossierRules.GetFileLocation(nummer);

                FluentValidation.Results.ValidationResult validationResult = new DossierValidator().Validate(dossier);

                if (validationResult.IsValid)
                {
                    dossierContext.Dossiers.Add(dossier);
                    result = dossierContext.SaveChanges();

                    this.RefreshDossierList(this.overviewForm.IsShowingArchivedItems());
                    if (result > 0)
                    {
                        id = dossier.Id;
                    }
                }
                else
                {
                    DossierValidator.DisplayErrorMessage(validationResult);
                }
            }

            return result;
        }

        public int DeleteDossier(int id, byte[] rowVersion)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Dossier dossier = dossierContext.Dossiers.Where(c => c.Id == id).First();
                dossierContext.Dossiers.Remove(dossier);
                result = dossierContext.SaveChanges();

                this.RefreshDossierList(this.overviewForm.IsShowingArchivedItems());
            }

            return result;
        }

        public void ShowPersonForm(int? id)
        {
                Controller.PersonController personController = new Controller.PersonController(id);
                personController.ShowView();
        }

        public void ExitApplication()
        {
            if (this.parent != null)
            {
                this.parent.Close();
            }
        }

        public List<Tuple<string, int>> GetAllPersons()
        {
            Controller.PersonController personController = new Controller.PersonController(null);

            return personController.GetNameTuples();
        }

        public int PersistLinkedPersonList(int dossierId, List<Tuple<string, int>> linkedPersons)
        {
            Controller.PersonController personController = new Controller.PersonController(dossierId);

            return personController.PersistLinkedPersonList(linkedPersons);
        }

        public List<string> GetAllProcedures()
        {
            return Automat.Rules.DossierRules.GetProcedureNames();
        }





    }
}
