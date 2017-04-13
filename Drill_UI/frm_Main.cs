﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drill_UI.App_Forms;

namespace Drill_UI
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
           
        }


        //Menu Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutOpsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var aboutForm = new frm_About();
            aboutForm.Show();
        }
    }
}
