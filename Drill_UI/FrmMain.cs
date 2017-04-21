using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Drill_UI.App_Controls;
using Drill_UI.App_Forms;

namespace Drill_UI
{
    public partial class FrmMain : Form
    {
        //Initialize Main Form
        public FrmMain()
        {
            InitializeComponent();
     
        }

        //Form Load  method
        private void frm_Main_Load(object sender, EventArgs e)
        {

            //Create flowpanel for Active Wells and add to Main container
            var activeWellsPanel = NewFlowPanel();
            this.panelMain.Controls.Add(activeWellsPanel);

            var activeWells = new List<string> { "638275","655062","655945","645573","655999","649223","658418","658419","658420","657816","838481","658494","659018","657973","658389","659012","647746","653263","836402"};
            var previewHours = 1;

            MessageBox.Show(activeWells.Count + "" + previewHours);

            for (var i = 0; i < activeWells.Count; ++i)
            {

                //create well panel2
                var wellPanel = new Panel()
                {
                    Name = "wellPanel_" + activeWells[i],
                    BackColor = Color.FromArgb(240, 240, 240),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(500, 350),
                    Enabled = true,
                    Visible = true
                };

                var dataWatcher = new WebBrowser()
                {
                    Dock = DockStyle.Fill,
                    Url = new System.Uri("http://okcdocprd007a:8080/datawatchvdd-frontend/workbook/#/RSTest/Single%20Well%20Rig%20Sensors/params/%7B%22UidWell%22%3A%22" + activeWells[i] + "%22%2C%22HH%22%3A%22"+ previewHours + "%22%7D"),
                    Visible = true
                };

                wellPanel.Controls.Add(dataWatcher);
                activeWellsPanel.Controls.Add(wellPanel);
            }
          
        }


        //Menu - Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Menu - About Form Button
        private void aboutOpsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new about form and show when clicked
            var aboutForm = new FrmAbout();
            aboutForm.Show();
      
        }

    
        //TODO: Enable gridPanel focus when mouseEnter to allow scrolling with mouse scroll whell
      
        
        //Create custom grid panel
        private static FlowLayoutPanel NewFlowPanel()
        {
            //Create Flow Panel
            var gridPanel = new FlowLayoutPanel()
            {
                Name = "pnl_FlowMain",
                BackColor = Color.FromArgb(66, 66, 66),
                AutoScroll = true,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Visible = true
            };
            return gridPanel;
        }

    }
}
