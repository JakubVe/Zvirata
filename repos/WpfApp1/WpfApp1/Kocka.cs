using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Kocka : Zvire
    {
        public int Chloupky { get; set; }
        public Kocka(string jmeno = "Micka", string barva = "Černá", int nohy = 4, int chloupky = 8, bool leta = false) : base (nohy,leta,barva,jmeno)
        {
            Chloupky = chloupky;
        }
        public override string VydejZvuk()
        {
            return "Mňau";
        }
    }
}
