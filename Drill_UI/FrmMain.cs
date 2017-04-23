using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Drill_UI.App_Controls;
using Drill_UI.App_Forms;
using Drill_UI.APP_Classes;

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
            pnl_Left.Location = new Point(-150,0);
            var activeWellsPanel = NewFlowPanel();
           
            //var well = new Well("Test" ,"654955");
         
            CreateActiveWellPanel();

            this.panelMain.Controls.Add(activeWellsPanel);

        }
    
        //Menu - Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateDataGrid()
        {
            var dataGrid = new DataGridView()
            {
                Dock = DockStyle.Fill,
                Columns = { }
            };

            panelMain.Controls.Add(dataGrid);
        }

        private void CreateActiveWellPanel()
        {
            //Create flowpanel for Active Wells and add to Main container
            var activeWellsPanel = NewFlowPanel();
            this.panelMain.Controls.Add(activeWellsPanel);

            var activeWells = new List<string> { "638275", "655945", "649223", "658418", "658419", "657816" };
            // var previewHours = 1;

            for (var i = 0; i < activeWells.Count; ++i)
            {

                var wellPanel = createWellPanel(activeWells[i]);
                var wellPanelUpper = new Panel()
                {
                    Name = "wellPanel_Upper" + activeWells[i],
                    BackColor = Color.FromArgb(240, 240, 240),
                    Size = new Size(600, 360),
                    Location = new Point(0, 0),
                    Enabled = true,
                    Visible = true
                };

                var dataWatch = new WebBrowser()
                {
                    Dock = DockStyle.Fill,
                    Url = new System.Uri("http://okcdocprd007a:8080/datawatchvdd-frontend/workbook/#/RSTest/Single%20Well%20Rig%20Sensors/params/%7B%22UidWell%22%3A%22" + activeWells[i] + "%22%7D"),
                    Visible = true
                };


                wellPanelUpper.Controls.Add(dataWatch);
                wellPanel.Controls.Add(wellPanelUpper);
                activeWellsPanel.Controls.Add(wellPanel);
                

                //Thread.Sleep(1000);
            }

        }

        private Panel createWellPanel(string pn)
        {
            var wellPanelMain = new Panel()
            {
                Name = "wellPanel_Main" + pn,
                BackColor = Color.FromArgb(240, 240, 240),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(600, 400),
                Enabled = true,
                Visible = true
            };
            //create well panel
            var wellPanelLower = new Panel()
            {
                Name = "wellPanel_Lower" + pn,
                BackColor = Color.FromArgb(160, 160, 160),
                Size = new Size(600, 40),
                Location = new Point(0, 360),
                Enabled = true,
                Visible = true
            };

            wellPanelMain.Controls.Add(wellPanelLower);
            return wellPanelMain;
        }

        //Menu - About Form Button
        private void aboutOpsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new about form and show when clicked
            var aboutForm = new FrmAbout();
            aboutForm.Show();
      
        }

        //TODO: Enable gridPanel focus when mouseEnter to allow scrolling with mouse scroll wheel
        
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

        private void pnl_Left_MouseEnter(object sender, EventArgs e)
        {
            var slideOut = new Point(0, 0);
            pnl_Left.Location = slideOut;
        }

        private void pnl_Left_MouseLeave(object sender, EventArgs e)
        {
            var slideIn = new Point(-150, 0);
            pnl_Left.Location = slideIn;
        }
    }
}
