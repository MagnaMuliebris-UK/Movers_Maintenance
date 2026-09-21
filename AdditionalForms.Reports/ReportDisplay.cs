using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    public partial class ReportDisplay : Form
    {
        public ReportDisplay()
        {
            InitializeComponent();
        }

        public void GetPicture(Bitmap bitmap)
        {
            pctbxHoldReport.Image = bitmap;
        }
    }
}
