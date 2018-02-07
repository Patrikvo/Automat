using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat
{
    public partial class DossierControl : UserControl
    {
        public DossierControl(): this(new Model.Dossier())
        {
            
        }

        public DossierControl(Model.Dossier dossier)
        {
            InitializeComponent();
            this.dossier = dossier;
            refreshModel();
        }


        public void refreshModel()
        {
            this.labelDossierNummer.Text = this.dossier.dossierNummer + " - " + this.dossier.dossierTitel;
            this.textBoxStandvanzaken.Text = this.dossier.dossierStandvanzaken;
        }


        Model.Dossier dossier;

        private void buttonOngedaanMaken_Click(object sender, EventArgs e)
        {
            this.textBoxStandvanzaken.Text = this.dossier.dossierStandvanzaken;
        }
    }
}
