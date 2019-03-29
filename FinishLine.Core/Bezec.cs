using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine
{
    public class Bezec
    {
        public string Meno { get; set; }
        public string Krajina { get; set; }
        public int Vek { get; set; }
        public string Pohlavie { get; set; }

        public Bezec(string meno, string krajina, int vek, string pohlavie)
        {
            Meno = meno;
            Krajina = krajina;
            Vek = vek;
            Pohlavie = pohlavie;
        }


    }
}
