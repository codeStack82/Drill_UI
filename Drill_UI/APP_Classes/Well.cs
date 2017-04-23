namespace Drill_UI.APP_Classes
{
    public class Well
    {
        public string Name { get; set; }
        public string Pn { get; set; }

        public Well(string name)
        {
            this.Name = name;
        }

        public Well(string name, string pn)
        {
            this.Name = name;
            this.Pn = pn;
        }
    }
}