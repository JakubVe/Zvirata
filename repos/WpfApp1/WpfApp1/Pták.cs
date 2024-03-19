using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Ptak : Zvire
    {
        public bool Vodni { get; set; }
        public Ptak(string jmeno = "Chip", string barva = "Modrá", bool leta = true, bool vodni = false, int nohy = 2) : base(nohy,leta,barva,jmeno)
        {
            Vodni = vodni;
        }
        public override string VydejZvuk()
        {
            return "Píp Píp";
        }
    }
}
