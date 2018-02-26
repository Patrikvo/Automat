/*  Notes:
 *
 * */

namespace Automat
{
    using System;
    using System.Windows.Forms;

    public partial class DossierControl : UserControl
    {
        private Model.Dossier dossier;

        public DossierControl()
            : this(new Model.Dossier())
        {
        }

        public DossierControl(Model.Dossier dossier)
        {
            this.InitializeComponent();
            this.dossier = dossier;
            this.RefreshModel();
        }

        public void RefreshModel()
        {
            this.labelDossierNummer.Text = this.dossier.DossierNummer + " - " + this.dossier.DossierTitel;
            this.textBoxStandvanzaken.Text = this.dossier.DossierStandvanzaken;
        }

        private void ButtonOngedaanMaken_Click(object sender, EventArgs e)
        {
            this.textBoxStandvanzaken.Text = this.dossier.DossierStandvanzaken;
        }
    }
}
