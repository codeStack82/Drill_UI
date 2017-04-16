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
            var wellList = new List<string>() {"FAITH-TORO DIM M4H", "Well 2", "Well 3", "Well 4", "Well 5", "Well 6", "Well 7" };
            var distList = new List<string>() { "EASTERN GULF COAST", "District 2", "District 3", "District 4", "District 5", "District 6", "District 7" };

            for (var i = 0; i < wellList.Count; ++i)
            {

                //create well panel2
                var wellPanel = new Panel()
                {
                    Name = "wellPanel" + wellList[i] ,
                    BackColor = SystemColors.ControlLightLight,
                    AutoScroll = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(775, 500),
                    Enabled = true,
                    Visible = true
                };

                var topPanel = new Panel()
                {
                    Name = "topPanel" + wellList[i],
                    BackColor = SystemColors.Highlight,
                    Dock = DockStyle.Top,
                    Height = 30,
                    ForeColor = SystemColors.ControlLightLight,
                    Padding = new Padding(5),
                    Margin = new Padding(5),
                    Enabled = true,
                    Visible = true
                };


                //Create well panel components
                var welllabel = new Label()
                {
                    Name = "lbl_" + wellList[i],
                    Text = wellList[i],
                    Width = 220,
                    ForeColor = SystemColors.ControlLightLight,
                    Location = new Point(250, 5)
                };

                var distlabel = new Label()
                {
                    Name = "lbl_" + distList[i],
                    Text = distList[i],
                    Width = 220,
                    Location = new Point(5, 5)
                };


                //Add controls to the top panel
                topPanel.Controls.Add(distlabel);
                topPanel.Controls.Add(welllabel);

                //Add all panel to the well panel
                wellPanel.Controls.Add(topPanel);


                //Add well panel to main flow panel
                this.pnl_Main.Controls.Add(wellPanel);
            }
          
        }


        private void setWellPanels(string wellName)
        {

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
            var aboutForm = new frm_About();
            aboutForm.Show();
      
        }

        //Drop Shadow method
            //TODO: Test drop shadow function more....?
        private void dropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }

        
    }
}
