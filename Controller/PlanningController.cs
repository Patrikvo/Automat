/*  Notes:
 *
 * */

namespace Automat.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Automat.Common;
    using Automat.Model;
    using Automat.View;

    public class PlanningController
    {
        private PlanningForm planningForm;
        private Form parent;

        public PlanningController(Form parent)
        {
            this.parent = parent;
            this.planningForm = new PlanningForm(this);
        }

        // private List<Planning> planningList;
        public List<Planning> GetEventList(int? dossierId)
        {
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                if (dossierId == null)
                {
                    return dossierContext.Planning.ToList();
                }
                else
                {
                    return dossierContext.Planning.Where(c => c.DossierId == dossierId).OrderBy(s => s.Deadline).ToList();

                    // return (from t3 in dossierContext.Planning where t3.Id == dossierId select t3).ToList();
                }
            }
        }

        public List<Tripple<string, DateTime, int>> GetEvents(int? dossierId)
        {
            List<Tripple<string, DateTime, int>> tripples = new List<Tripple<string, DateTime, int>>();

            foreach (Planning p in this.GetEventList(dossierId))
            {
                tripples.Add(new Tripple<string, DateTime, int>(p.Description, p.Deadline, p.Id));
            }

            return tripples;
        }

        public int AddEvent(int dossierId, string description, int responsible, DateTime deadline, DateTime? completionDate)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Planning planning = new Planning();
                planning.DossierId = dossierId;
                planning.Description = description;
                planning.Responsible = responsible;
                planning.Deadline = deadline;
                planning.CompletionDate = completionDate;
                planning.Created = DateTime.Now;

                /*  FluentValidation.Results.ValidationResult validationResult = new DossierValidator().Validate(dossier);

                    if (validationResult.IsValid)
                    {*/
                dossierContext.Planning.Add(planning);

                result = dossierContext.SaveChanges();

                /*     }
                     else
                     {
                         DossierValidator.DisplayErrorMessage(validationResult);
                     }*/
            }

            return result;
        }

        public int RemoveEvent(int id)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Planning planning = dossierContext.Planning.Where(c => c.Id == id).First();
                dossierContext.Planning.Remove(planning);
                result = dossierContext.SaveChanges();
            }

            return result;
        }

        public int GetEvent(int id, out int dossierId, out string description, out int responsible, out DateTime deadline, out DateTime? completionDate, out DateTime creationDate)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Planning planning = dossierContext.Planning.Where(c => c.Id == id).First();
                if (planning != null)
                {
                    result = 1;
                }

                dossierId = planning.DossierId;
                description = planning.Description;
                responsible = planning.Responsible;
                deadline = planning.Deadline;
                completionDate = planning.CompletionDate;
                creationDate = planning.Created;
            }

            return result;
        }

        public int UpdateEvent(int id, int dossierId, string description, int responsible, DateTime deadline, DateTime? completionDate)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Planning planning = dossierContext.Planning.Where(c => c.Id == id).First();
                if (planning != null)
                {
                    planning.DossierId = dossierId;
                    planning.Description = description;
                    planning.Responsible = responsible;
                    planning.Deadline = deadline;
                    planning.CompletionDate = completionDate;
                    result = dossierContext.SaveChanges();
                }
            }

            return result;
        }

        internal void ShowView()
        {
            if (this.planningForm != null)
            {
                this.planningForm.Show();
            }
        }
    }
}
