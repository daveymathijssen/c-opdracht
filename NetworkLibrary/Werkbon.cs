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

        public Werkbon(string werkbon)
        {
            this.werkbon = werkbon;
        }

    }
}
