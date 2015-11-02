using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary
{
    [Serializable]
    public class Werkopdracht
    {
        private string werkbon;
        private DateTime aanmaakDatum;
        private DateTime uitvoerDatum;
        private Bedrijf bedrijf;
        private string werkomschrijving;
        private List<User> werknemers;
        private List<Werkbon> werkbonnen;

        //specifieke opdrachtvariabelen
        private string typeKit;
        private string kleuren;
        //null als er geen ladder nodig is
        private double ladderHoogte;

        /// <summary>
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        public Werkopdracht(string werkbon, DateTime uitvoerDatum, Bedrijf bedrijf)
        {
           
        }
    }
}
