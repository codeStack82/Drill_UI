using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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

        private readonly List<Panel> _mainPanelList = new List<Panel>();
        private readonly List<Panel> _upperPanelList = new List<Panel>();
        private readonly List<Panel> _lowerPanelList = new List<Panel>();
        private readonly List<Panel> _alarmPanelList = new List<Panel>();

        //Form Load  method
        private void frm_Main_Load(object sender, EventArgs e)
        {
            //onLoad 
            pnl_Left.Location = new Point(-150, 0);
            var activeWellsPanel = NewFlowPanel();


            var activeWells = new List<string> {"638275", "655945", "649223", "658418", "658419", "657816"};//, "655998", "658419", "647746" };

            //create each well panel and add to the active wells panel
            foreach (var w in activeWells)
            {
                var well = CreateWellPanel(w);
                activeWellsPanel.Controls.Add(well);
            }

            panelMain.Controls.Add(activeWellsPanel);


            //TODO: Create async thread to add each webBrowser.....some not loading
            //Add webBrowser to each uppPanel
            var i = 0;
            foreach (Panel p in _upperPanelList)
            {
                var dataWatch = new WebBrowser()
                {
                    Dock = DockStyle.Fill,
                    Url = new System.Uri("http://okcdocprd007a:8080/datawatchvdd-frontend/workbook/#/RSTest/Single%20Well%20Rig%20Sensors/params/%7B%22UidWell%22%3A%22" + activeWells[i] + "%22%7D"),
                    Visible = true
                };

                p.Controls.Add(dataWatch);
                i++;

            }
        }

        //Create Sustom Well Panel
        private Panel CreateWellPanel(string pn)
        {
            var wellPanelMain = new Panel()
            {
                Name = "wellPanel_Main_" + pn,
                BackColor = Color.FromArgb(240, 240, 240),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(600, 400),
                Enabled = true,
                Visible = true
            };
            _mainPanelList.Add(wellPanelMain);

            var wellPanelUpper = new Panel()
            {
                Name = "wellPanel_Upper_" + pn,
                BackColor = Color.FromArgb(240, 240, 240),
                Size = new Size(600, 360),
                Location = new Point(0, 0),
                Enabled = true,
                Visible = true
            };
            _upperPanelList.Add(wellPanelUpper);

            var wellPanelLower = new Panel()
            {
                Name = "wellPanel_Lower_" + pn,
                BackColor = Color.FromArgb(160, 160, 160),
                Size = new Size(600, 40),
                Location = new Point(0, 360),
                Enabled = true,
                Visible = true
            };
            _lowerPanelList.Add(wellPanelLower);

            var alarmPanel = new Panel()
            {
                Name = "alarmPanel_" + pn,
                BackColor = Color.DarkGray,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(100, 8),
                Size = new Size(400, 25)

            };
            _alarmPanelList.Add(alarmPanel);

            alarmPanel.MouseEnter += delegate
            {
                alarmPanel.BackColor = Color.DarkRed;
            };
            alarmPanel.MouseLeave += delegate
            {
                alarmPanel.BackColor = Color.DarkGray;
            };

            var btnFullView = new Button()
            {
                Name = "btn_Lower_" + pn,
                Location = new Point(5, 8),
                Font = new Font("Microsoft Sans Serif", 8.0f),
                ForeColor = Color.FromArgb(250, 250, 250),
                Text = "Full",
                Width = 40,
                FlatStyle = FlatStyle.Flat
            };

            btnFullView.Click += delegate
            {
                MessageBox.Show("PN: " + pn + "\n\nGood Job, You can click a button!");
            };


            wellPanelLower.Controls.Add(alarmPanel);
            wellPanelLower.Controls.Add(btnFullView);
            wellPanelMain.Controls.Add(wellPanelUpper);
            wellPanelMain.Controls.Add(wellPanelLower);
            return wellPanelMain;
        }

        //Create Data Grid for table type  info
        private void CreateDataGrid()
        {
            var dataGrid = new DataGridView()
            {
                Dock = DockStyle.Fill,
                Columns = { }
            };

            panelMain.Controls.Add(dataGrid);
        }

        //Create custom flow panelfor grid layout
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

        //Main Left Panel mouse Enter Event
        private void pnl_Left_MouseEnter(object sender, EventArgs e)
        {
            var slideOut = new Point(0, 0);
            Thread.Sleep(200);
            pnl_Left.Location = slideOut;
        }

        //Main Left Panel mouse Leave Event
        private void pnl_Left_MouseLeave(object sender, EventArgs e)
        {
            var slideIn = new Point(-150, 0);
            pnl_Left.Location = slideIn;
        }

        //Helper method -> print panel List names
        private void GetPanelListNames()
        {
            //print mainPanel names
            var sb = new StringBuilder();
            foreach (Panel MainPanel in _mainPanelList)
            {
                sb.Append(MainPanel.Name + "\n");
            }

            foreach (Panel MainPanel in _upperPanelList)
            {
                sb.Append(MainPanel.Name + "\n");
            }

            foreach (Panel MainPanel in _lowerPanelList)
            {
                sb.Append(MainPanel.Name + "\n");
            }

            foreach (Panel MainPanel in _alarmPanelList)
            {
                sb.Append(MainPanel.Name + "\n");
            }
            MessageBox.Show(sb.ToString());
        }

        //Menu - About Form Button
        private void aboutOpsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new about form and show when clicked
            var aboutForm = new FrmAbout();
            aboutForm.Show();

        }

        //Menu - Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Depreciated -> Delete!!
        private void CreateActiveWellPanels(string pn)
        {
            //Create flowpanel for Active Wells and add to Main container
            //var activeWellsPanel = NewFlowPanel();
            //this.panelMain.Controls.Add(activeWellsPanel);

            //var activeWells = new List<string> { "638275", "655945", "649223", "658418", "658419", "657816","655998","658419","647746"};
            // var previewHours = 1;
            //activeWells.Count

            //for (var i = 0; i < activeWells.Count; ++i)
            //{

            var wellPanel = CreateWellPanel(pn);
            var wellPanelUpper = new Panel()
            {
                Name = "wellPanel_Upper" + pn,
                BackColor = Color.FromArgb(240, 240, 240),
                Size = new Size(600, 360),
                Location = new Point(0, 0),
                Enabled = true,
                Visible = true
            };

            //var dataWatch = new WebBrowser()
            //{
            //    Dock = DockStyle.Fill,
            //    Url = new System.Uri("http://okcdocprd007a:8080/datawatchvdd-frontend/workbook/#/RSTest/Single%20Well%20Rig%20Sensors/params/%7B%22UidWell%22%3A%22" + activeWells[i] + "%22%7D"),
            //    Visible = true
            //};


            //wellPanelUpper.Controls.Add(dataWatch);
            wellPanel.Controls.Add(wellPanelUpper);
            //activeWellsPanel.Controls.Add(wellPanel);
            //Thread.Sleep(2000);
            //}

        }

    }
}
