using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Zvire
    {
        public int Nohy { get; set; }
        public bool Leta { get; set; }
        public string Barva { get; set; }
        public string Jmeno { get; set; }

        public Zvire(int nohy, bool leta, string barva, string jmeno)
        {
            Nohy = nohy;
            Jmeno = jmeno;
            Barva = barva;
            Jmeno = jmeno;
        }
        public virtual string VydejZvuk()
        {
            return "Zvuk zvířete";
        }
    }
}
