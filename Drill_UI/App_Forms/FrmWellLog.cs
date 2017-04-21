using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drill_UI.App_Forms
{
    public partial class FrmWellLog : Form
    {
        public FrmWellLog()
        {
            InitializeComponent();

            //Dark Theme Color List
            var main = Color.FromArgb(33, 33, 33);
            var mainBc = Color.FromArgb(48, 48, 48);
            var gridBc = Color.FromArgb(30, 120, 175);
            var smallGridBc = Color.FromArgb(240, 240, 240);
            var flowPanel = Color.FromArgb(66, 66, 66);
            var lightText = Color.FromArgb(240, 240, 240);

        }

        private void frm_WellLog_Load(object sender, EventArgs e)
        {

        }
    }
}
