using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automat.Model;
using Automat.View;
using System.Data.Entity.Infrastructure;

namespace Automat.Controller
{
    public class OverviewController
    {
        OverviewForm overviewForm;
        List<Dossier> dossierList;

        public OverviewController(Form1 parent)
        {
            this.parent = parent;

            this.overviewForm = new OverviewForm();
            this.overviewForm.selectWithID = showWithID;
            this.overviewForm.saveDossier = SaveDossier;
            this.overviewForm.saveNewDossier = saveNewDossier;
            this.overviewForm.deleteDossier = deleteDossier;

            this.overviewForm.showPersonForm = showPersonForm;
            this.overviewForm.exitApplication = this.exitApplication;
            this.overviewForm.refreshDossierList = this.refreshDossierList;
            this.overviewForm.getAllPersons = this.GetAllPersons;
            this.overviewForm.persistLinkedPersonList = this.persistLinkedPersonList;
            refreshDossierList(false);

            
        }


        /*
        public int saveDossierArchiveProperty(int id, bool isArchived, byte[] rowVersion)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Dossier dossier = dossierContext.dossiers.SingleOrDefault(c => c.Id == id);

                // the dossier is delete by another user?
                if (dossier == null)
                {
                    this.overviewForm.setStatusText("Entry was deleted by another user.");
                    return 0;
                }
                else
                {
                    if (Database.DossierContext.ByteArrayCompare(rowVersion, dossier.RowVersion))
                    {
                        dossier.isGearchiveerd = isArchived;

                        result = dossierContext.SaveChanges();

                        refreshDossierList(this.overviewForm.isShowingArchivedItems());
                  //      this.dossierList = dossierContext.dossiers.ToList();
                   //     this.overviewForm.setDossierList(this.dossierList, "Name", "Id");
                    }
                    else
                    {
                        this.overviewForm.setStatusText("Entry was modified by another user.");
                    }
                }

            }
            return result;
        }
        */



        public void refreshDossierList(bool showArchived)
        {
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                if (!showArchived)
                {
                    this.dossierList = dossierContext.dossiers.Where(c => c.isGearchiveerd == false).ToList();
                }
                else
                {
                    this.dossierList = dossierContext.dossiers.ToList();
                }
                this.overviewForm.setDossierList(this.dossierList, "Name", "Id");
            }
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
            Dossier dossier = null;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                dossier = dossierContext.dossiers.SingleOrDefault(c => c.Id == id);
            }
            if (dossier != null)
            {
                Controller.PersonController personController = new Controller.PersonController(id);
                
                List<Tuple<string, int>> contactpersonen = personController.getNameTuples();
                this.overviewForm.setdossier(dossier.Id, dossier.dossierNummer, dossier.dossierTitel, dossier.dossierStandvanzaken, dossier.isGearchiveerd, contactpersonen, dossier.dossierLinkToFiles, dossier.RowVersion);
            }
        }

        public int SaveDossier(int id, string nummer, string titel, string stavaza, bool isArchived, string linkTofiles, byte[] rowVersion)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Dossier dossier = dossierContext.dossiers.SingleOrDefault(c => c.Id == id);

                // the dossier is delete by another user?
                if (dossier == null)
                {
                    this.overviewForm.setStatusText("Entry was deleted by another user.");
                    return saveNewDossier(out id, nummer, titel, stavaza);
                }
                else
                {
                    if (Database.DossierContext.ByteArrayCompare(rowVersion, dossier.RowVersion))
                    {
                        dossier.dossierNummer = nummer;
                        dossier.dossierTitel = titel;
                        dossier.dossierStandvanzaken = stavaza;
                        dossier.isGearchiveerd = isArchived;
                        if (linkTofiles != "")
                        {
                            dossier.dossierLinkToFiles = linkTofiles;
                        }
                        else
                        {
                            dossier.dossierLinkToFiles = Automat.Rules.DossierRules.getFileLocation(nummer);
                        }
                        result = dossierContext.SaveChanges();


                        refreshDossierList(this.overviewForm.isShowingArchivedItems());
                    }
                    else
                    {
                        this.overviewForm.setStatusText("Entry was modified by another user.");
                    }
                }
       
            }
            return result;
        }

        public int saveNewDossier(out int id, string nummer, string titel, string stavaza)
        {
            
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Dossier dossier = new Dossier();
                dossier.dossierNummer = nummer;
                dossier.dossierTitel = titel;
                dossier.dossierStandvanzaken = stavaza;
                dossier.isGearchiveerd = false;
                dossier.dossierLinkToFiles = Automat.Rules.DossierRules.getFileLocation(nummer);
                dossierContext.dossiers.Add(dossier);
                result = dossierContext.SaveChanges();

                refreshDossierList(this.overviewForm.isShowingArchivedItems());
                if (result > 0)
                {
                    id = dossier.Id;
                }
                else
                {
                    id = -1;
                }
            }
            return result;

        }

        public int deleteDossier(int id, byte[] rowVersion)
        {
            int result = 0;
            using (Database.DossierContext dossierContext = new Database.DossierContext())
            {
                Dossier dossier = dossierContext.dossiers.Where(c => c.Id == id).First(); ;
                dossierContext.dossiers.Remove(dossier);
                result = dossierContext.SaveChanges();

                refreshDossierList(this.overviewForm.isShowingArchivedItems());

            }
            return result;
        }



        public void showPersonForm(int? id)
        {
                Controller.PersonController personController = new Controller.PersonController(id);
                personController.showView();
        }


        public void exitApplication()
        {
            this.parent.exitApplication();
        }

        public string lastError { get; set; }

        public List<Tuple<string, int>> GetAllPersons()
        {
            Controller.PersonController personController = new Controller.PersonController(null);

            return personController.getNameTuples();
        }

        public int persistLinkedPersonList(int dossierId, List<Tuple<string, int>> linkedPersons)
        {
            Controller.PersonController personController = new Controller.PersonController(dossierId);

            return personController.persistLinkedPersonList(linkedPersons);
        }

        Form1 parent;

    }
}
