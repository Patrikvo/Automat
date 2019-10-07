/*  Notes:
 *
 * */

namespace Automat.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Automat.Common;
    using Automat.Model;
    using Automat.View;
    using Automat.View.Overview;

    public class OverviewController
    {
        private OverviewForm overviewForm;
        private PlanningSubForm planningSubForm;
        private List<Dossier> dossierList;
        private Form parent;

        public OverviewController(Form parent)
        {
            this.parent = parent;
            this.planningSubForm = new Automat.View.Overview.PlanningSubForm(this);
            this.overviewForm = new OverviewForm(this, this.planningSubForm);

            this.RefreshDossierList(false);
        }

        public int DossierId { get; private set; }

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
                string type = Rules.DossierRules.GetProcedureTypeName(dossier.DossierType, true);
                string procuringEnityName = Rules.DossierRules.GetProcuringEntityName(dossier.ProcuringEnity);
                string contractTypeName = Rules.DossierRules.GetContractTypeName(dossier.TypeOfContract);

                Controller.PlanningController planningController = new PlanningController(null);
                List<Tripple<string, DateTime, int>> events = planningController.GetEvents(id);

                this.DossierId = id;

                this.overviewForm.Setdossier(
                                                dossier.Id,
                                                dossier.DossierNummer,
                                                dossier.DossierTitel,
                                                dossier.DossierStandvanzaken,
                                                dossier.IsGearchiveerd,
                                                contactpersonen,
                                                dossier.DossierLinkToFiles,
                                                procedure,
                                                type,
                                                dossier.IsEuropeanPublished,
                                                procuringEnityName,
                                                contractTypeName,
                                                events,
                                                dossier.RowVersion);
            }
        }

        public int SaveDossier(
                                int id,
                                string nummer,
                                string titel,
                                string stavaza,
                                bool isArchived,
                                string linkTofiles,
                                string procedure,
                                string type,
                                bool isEuropeanPublished,
                                string procuringEnityName,
                                string contractTypeName,
                                byte[] rowVersion)
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
                        dossier.DossierType = Rules.DossierRules.GetProcedureTypeID(type, true);
                        dossier.IsEuropeanPublished = isEuropeanPublished;
                        dossier.ProcuringEnity = Rules.DossierRules.GetProcuringEntityID(procuringEnityName);
                        dossier.TypeOfContract = Rules.DossierRules.GetContractTypeID(contractTypeName);

                        // Do validation of Dossier object:
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

        public void ShowPlanningForm()
        {
            Controller.PlanningController planningController = new PlanningController(null);
            planningController.ShowView();
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

        public int AddEvent(int dossierId, string description, int responsible, DateTime deadline, DateTime? completationDate)
        {
            PlanningController planningController = new PlanningController(null);
            int result = planningController.AddEvent(dossierId, description, responsible, deadline, completationDate);
            if (result > 0)
            {
                this.RefreshEventList(dossierId);
            }

            return result;
        }

        public int RemoveEvent(int id, int dossierId)
        {
            PlanningController planningController = new PlanningController(null);
            int result = planningController.RemoveEvent(id);
            if (result > 0)
            {
                this.RefreshEventList(dossierId);
            }

            return result;
        }

        public int GetEvent(int id, out int dossierId, out string description, out int responsible, out DateTime deadline, out DateTime? completionDate, out DateTime creationDate)
        {
            PlanningController planningController = new PlanningController(null);

            int result = planningController.GetEvent(id, out dossierId, out description, out responsible, out deadline, out completionDate, out creationDate);
            return result;
        }

        public int UpdateEvent(int id, int dossierId, string description, int responsible, DateTime deadline, DateTime? completationDate)
        {
            PlanningController planningController = new PlanningController(null);

            int result = planningController.UpdateEvent(id, dossierId, description, responsible, deadline, completationDate);
            if (result > 0)
            {
                this.RefreshEventList(dossierId);
            }

            return result;
        }

        public bool ShowEventUpdateForm(int eventId)
        {
            bool result = false;
            EventForm eventForm = new EventForm();
            eventForm.ShowEvent(eventId);
            DialogResult dialogResult = eventForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                result = true;
                this.RefreshEventList(eventForm.DossierID);
            }

            return result;
        }

        public bool ShowEventAddForm(DateTime date)
        {
            bool result = false;
            EventForm eventForm = new EventForm();
            eventForm.DossierID = this.DossierId;
            eventForm.SetDeadlineDate(date);
            DialogResult dialogResult = eventForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                result = true;
                this.RefreshEventList(eventForm.DossierID);
            }

            return result;
        }

        private void RefreshEventList(int dossierId)
        {
            Controller.PlanningController planningController = new PlanningController(null);
            List<Tripple<string, DateTime, int>> events = planningController.GetEvents(dossierId);
            this.overviewForm.DisplayEvents(events);
        }
    }
}
