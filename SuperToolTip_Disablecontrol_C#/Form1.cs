using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Supertooltip
{
    public partial class Form1 : MetroForm
    {
        private SuperToolTip superToolTip1;
        public Form1()
        {
           InitializeComponent();
           superToolTip1 = new SuperToolTip();

        }
        bool IsShown = false;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctrl = this.GetChildAtPoint(e.Location);
            if (ctrl != null)
            {
                if (ctrl == this.buttonAdv1 && !IsShown)
                {
                    //Initializes the ToolTipInfo
                    ToolTipInfo tooltip = new ToolTipInfo();
                    tooltip.Body.Text = "SuperToolTip";
                    //Sets the SuperToolTip
                    this.superToolTip1.SetToolTip(this.buttonAdv1, tooltip);
                    System.Drawing.Point pt1 = new System.Drawing.Point(ctrl.Location.X + 20, ctrl.Location.Y + 30);
                    //Shows the SuperToolTip in the specified location
                    this.superToolTip1.Show(tooltip, this.PointToScreen(pt1), 1000);
                    IsShown = true;
                }
            }
            else
            {
                this.superToolTip1.Hide();
                IsShown = false;
            }
        }
    }
}
