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
        public DateTime aanmaakDatum;
        public DateTime uitvoerDatum { get; set; }
        public Bedrijf bedrijf;
        public string werkomschrijving;
        public List<User> werknemers;

        public Werkbon(string werkbon, Bedrijf bedrijf)
        {
            this.werkbon = werkbon;
        }

    }
}
