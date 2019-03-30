using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class BezecVysledky
    {

        public int ID { get; set; }
        public string Meno { get; set; }
        public DateTime Teraz { get; set; }
        public TimeSpan DlzkaKola { get; set; }
        public int Kolo { get; set; }


        public BezecVysledky(int iD, string meno, DateTime teraz, TimeSpan dlzkaKola, int kolo)
        {
            ID = iD;
            Meno = meno;
            Teraz = teraz;
            DlzkaKola = dlzkaKola;
            Kolo = kolo;
        }
    }
}
