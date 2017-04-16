using System.Drawing;
using System.Windows.Forms;

namespace Drill_UI.APP_Classes
{


    public class PanelUtility
    {
       
        public PanelUtility(int id)
        {
            //Create new well panel and set properties
            var wellPanel = new Panel()
            {
                Name = "well_Panel" + id ,
                BackColor = SystemColors.ButtonHighlight,
                AutoScroll = true,
                Size = new Size(300, 300),
                Padding = new Padding(5),
                Margin = new Padding(5),
                Enabled = true,
                Visible = true
            };
        }
    }

}