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

        internal void ShowView()
        {
            if (this.planningForm != null)
            {
                this.planningForm.Show();
            }
        }
    }
}
