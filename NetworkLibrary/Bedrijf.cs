using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary
{
    [Serializable]
    public class Bedrijf
    {
        private string naam;
        private string bedrijfsNummer;
        private string contactPersoon;
        private string telefoonNummer;

        public Bedrijf(string naam, string bedrijfsNummer, string contactPersoon, string telefoonNummer)
        {
            this.naam = naam;
            this.bedrijfsNummer = bedrijfsNummer;
            this.contactPersoon = contactPersoon;
            this.telefoonNummer = telefoonNummer;
        }
    }
}
