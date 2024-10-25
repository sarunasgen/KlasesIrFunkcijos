using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasiuIrFunkcijuPavyzdys
{
    public class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public int GimimoMetai { get; set; }

        public Zmogus()
        {

        }

        public Zmogus(string vardas, string pavarde, int gimimoMetai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoMetai;
        }

        public bool ArMetaiLyginiai()
        {
            if (GimimoMetai % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
