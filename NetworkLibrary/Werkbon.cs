using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary
{
    [Serializable]
    public class Werkbon
    {
        public string werkbon { get; }
        public DateTime aanmaakDatum { get; }
        public DateTime uitvoerDatum { get; set; }
        public string bedrijf { get; set; }
        public string werkomschrijving { get; set; }
        public List<User> werknemers { get; set; }

        public Werkbon(string werkbon, string bedrijf, DateTime uitvoerDatum, string werkomschrijving, List<User> werknemers)
        {
            this.werkbon = werkbon;
            this.bedrijf = bedrijf;
            this.uitvoerDatum = uitvoerDatum;
            this.werkomschrijving = werkomschrijving;
            this.werknemers = werknemers;
            this.aanmaakDatum = DateTime.Today;

        }

    }
}
