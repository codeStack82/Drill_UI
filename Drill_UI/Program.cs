using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drill_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //public static readonly List<Panel> MainPanelList = new List<Panel>();
        //public static readonly List<Panel> UpperPanelList = new List<Panel>();
        //public static readonly List<Panel> LowerPanelList = new List<Panel>();
        //public static readonly List<Panel> AlarmPanelList = new List<Panel>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

        }
    }
}
