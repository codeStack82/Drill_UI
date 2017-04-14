using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drill_UI.APP_Classes
{
    public class PanelsUtility
    {
        public static FlowLayoutPanel create_FlowPanel() {
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();

            //Flow panel Settings
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            return flowPanel;
        }

        public static Panel create_WellPanel() {
            Panel panel = new Panel();

            //Well panel settigns
            panel.Size = new System.Drawing.Size(400,400);
   

            return panel;
        }

    }
}
