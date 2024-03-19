using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class pes : Zvire
    {
        public string Rasa { get; set; }

        public pes(string jmeno = "Alík", int nohy =4 , string barva = "Hnědá", bool leta = false, string rasa = "Německý ovčák") : base( nohy, leta,barva,jmeno)
        {
            Rasa = rasa;
        }
        public override string VydejZvuk()
        {
            return "Haf Haf";
        }
    }
}
