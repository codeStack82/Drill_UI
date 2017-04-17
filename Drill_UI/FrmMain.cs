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
            //Dark Theme Color List
            var main = Color.FromArgb(33, 33, 33);
            var mainBC = Color.FromArgb(48, 48, 48);
            var gridBC = Color.FromArgb(100,100,100);
            var smallGridBC = Color.FromArgb(240, 240, 240);
            var darkText = Color.FromArgb(85, 85, 85);
            var lightText = Color.FromArgb(240,240,240);


            var wellList = new List<string>() {"FAITH-TORO DIM M4H", "FAITH-TORO DIM M4H", "FAITH-TORO DIM M4H", "FAITH-TORO DIM M4H", "FAITH-TORO DIM M4H", "FAITH-TORO DIM M4H", "FAITH-TORO DIM M4H" };
            var distList = new List<string>() { "EASTERN GULF COAST", "EASTERN GULF COAST", "EASTERN GULF COAST", "EASTERN GULF COAST", "EASTERN GULF COAST", "EASTERN GULF COAST", "EASTERN GULF COAST" };

            for (var i = 0; i < wellList.Count; ++i)
            {

                //create well panel2
                var wellPanel = new Panel()
                {
                    Name = "wellPanel" + wellList[i] ,
                    BackColor = smallGridBC,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(500, 400),
                    Enabled = true,
                    Visible = true
                };

                var topPanel = new Panel()
                {
                    Name = "topPanel" + wellList[i],
                    BackColor = gridBC,
                    Dock = DockStyle.Top,
                    Height = 30,
                    ForeColor = lightText,
                    BorderStyle = BorderStyle.FixedSingle,
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
                    Width = 175,
                    ForeColor = lightText,
                    Location = new Point(330, 5)
                };

                var distlabel = new Label()
                {
                    Name = "lbl_" + distList[i],
                    Text = distList[i],
                    Width = 220,
                    ForeColor = lightText,
                    Location = new Point(5, 5)
                };


                //Add controls to the top panel
                topPanel.Controls.Add(distlabel);
                topPanel.Controls.Add(welllabel);

                //Add all panel to the well panel
                wellPanel.Controls.Add(topPanel);
                wellPanel.Paint += DropShadow;

                //Add well panel to main flow panel
                this.pnl_Main.Controls.Add(wellPanel);
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
            var aboutForm = new frm_About();
            aboutForm.Show();
      
        }

        //Drop Shadow method
        private static void DropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(211, 211, 211);
            shadow[1] = Color.FromArgb(211, 211, 211);
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

        //Enable flowpanel focus when enter to allow scrolling with mouse
        private void pnl_Main_MouseEnter(object sender, EventArgs e)
        {
            pnl_Main.Focus();
        }
    }
}
