using System.Drawing;
using System.Windows.Forms;

namespace Drill_UI.APP_Classes
{
    public class WellPanel : Panel
    {
        public string WellName { get; set; }

        public WellPanel(string name)
        {
            WellName = name;
            var panel = new Panel() //TODO: Panel settgins not working....?
            {
                Name = "wellPanel_Main" + WellName,
                BackColor = Color.FromArgb(20, 20, 240),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(600, 400),
                Enabled = true,
                Visible = true
            };
        }
    }
}
