/*  Notes:
 *
 * */

namespace Automat
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            Controller.OverviewController overviewController = new Controller.OverviewController(this);
            overviewController.ShowView();
        }

        public void ShowPersonForm()
        {
            Controller.PersonController personController = new Controller.PersonController(null);
            personController.ShowView();
        }

        public void ExitApplication()
        {
            this.Close();
        }
    }
}
