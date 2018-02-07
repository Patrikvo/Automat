using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automat.Model;
using Automat.View;

namespace Automat.Controller
{
    public class OverviewController
    {
        OverviewForm overviewForm;
        List<Dossier> dossierList;

        public OverviewController(Database.DossierContext dossierContext)
        {
            this.dossierContext = dossierContext;
            this.dossierList = dossierContext.dossiers.ToList();
            this.overviewForm = new OverviewForm();
            this.overviewForm.selectWithID = showWithID;
            this.overviewForm.saveDossier = SaveDossier;
            this.overviewForm.saveNewDossier = saveNewDossier;
            this.overviewForm.deleteDossier = deleteDossier;

            this.overviewForm.setDossierList(this.dossierList, "Name", "Id");
        }

        public void showView()
        {
            if (overviewForm != null)
            {
                overviewForm.Show();
            }

        }

        public void showWithID(int id)
        {
            Dossier dossier =  this.dossierContext.dossiers.SingleOrDefault(c => c.Id == id);
            this.overviewForm.setdossier(dossier.Id, dossier.dossierNummer, dossier.dossierTitel, dossier.dossierStandvanzaken);
        }

        public int SaveDossier(int id, string nummer, string titel, string stavaza)
        {
            int result = 0;
            Dossier dossier = this.dossierContext.dossiers.SingleOrDefault(c => c.Id == id);
            if (dossier != null)
            {
                dossier.dossierNummer = nummer;
                dossier.dossierTitel = titel;
                dossier.dossierStandvanzaken = stavaza;
                result =  this.dossierContext.SaveChanges();
                this.dossierList = dossierContext.dossiers.ToList();
                this.overviewForm.setDossierList(this.dossierList, "Name", "Id");
            }

            return result;
        }

        public int saveNewDossier(out int id, string nummer, string titel, string stavaza)
        {
            int result = 0;
            Dossier dossier = new Dossier();
            dossier.dossierNummer = nummer;
            dossier.dossierTitel = titel;
            dossier.dossierStandvanzaken = stavaza;
            this.dossierContext.dossiers.Add(dossier);
            result = this.dossierContext.SaveChanges();
            this.dossierList = dossierContext.dossiers.ToList();
            this.overviewForm.setDossierList(this.dossierList, "Name", "Id");
            if (result > 0)
            {
                id = dossier.Id;
            }
            else
            {
                id = -1;
            }

            return result;

        }

        public int deleteDossier(int id)
        {
            int result = 0;
            Dossier dossier = this.dossierContext.dossiers.Where(c => c.Id == id).First(); ;
            this.dossierContext.dossiers.Remove(dossier);
            result = this.dossierContext.SaveChanges();
            this.dossierList = dossierContext.dossiers.ToList();
            this.overviewForm.setDossierList(this.dossierList, "Name", "Id");

            return result;
        }






        Database.DossierContext dossierContext;
    }
}
