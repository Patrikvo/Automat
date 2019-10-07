/*
 * */
namespace Automat.Controls
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

    public partial class PlanningControl : System.Windows.Forms.UserControl
    {
        public PlanningControl()
        {
            this.InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            this.DrawDateLine(g, DateTime.Now, DateTime.Now.AddDays(20), e.ClipRectangle.Width, e.ClipRectangle.Height);
        }

        private void DrawDateLine(Graphics g, DateTime from, DateTime to, float length, float height)
        {
            int numDays = (to - from).Days;
            int dayLength = (int)(length / numDays);

            for (int i = 0; i <= numDays; i++)
            {
                g.DrawLine(Pens.Black, i * dayLength, 0, i * dayLength, height);
            }

            // g.FillRectangle(Brushes.Red, 0, 0, length, height);
        }
    }
}
