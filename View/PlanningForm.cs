

namespace Automat.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Automat.Controller;
    using Automat.Model;

    public partial class PlanningForm : Form
    {
        private PlanningController planningController;


        public PlanningForm(PlanningController planningController)
        {
            InitializeComponent();
            this.planningController = planningController;
        }
    }
}
