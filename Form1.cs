using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Controller.OverviewController overviewController = new Controller.OverviewController(this);
            overviewController.showView();



            
            /*
            int j = 0;
            
            foreach (var dossier in dossierContext.dossiers)
            {
                j++;
                DossierControl dc = new DossierControl(dossier);
                this.tableLayoutPanel1.Controls.Add(dc);

                





                if (j > 20) { break; }
            }
            
            for (int i = 0; i < this.tableLayoutPanel1.RowStyles.Count; i++)
            {
                this.tableLayoutPanel1.RowStyles[i] = new RowStyle(SizeType.Absolute, this.tableLayoutPanel1.Controls[0].Height);
            }




                /*
                using (var db = new Database.DossierContext())
                {
                    for (int i = 0; i < 250; i++)
                    {
                        db.dossiers.Add(new Model.Dossier { dossierNummer = "nummer" + i.ToString(), dossierTitel = "titel" + i.ToString(), dossierStandvanzaken = "stavaza" + i.ToString() });
                    }
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} records saved to database", count);

                    Console.WriteLine();
                    Console.WriteLine("All blogs in database:");
                    foreach (var blog in db.dossiers)
                    {
                        Console.WriteLine(" - {0}", blog.dossierNummer);
                    }
                }
                */

            }


        public void showPersonForm()
        {
            Controller.PersonController personController = new Controller.PersonController(null);
            personController.showView();
        }


        

        public void exitApplication()
        {
            this.Close();
        }

    
    }
}
