using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine
{
    /// <summary>
    /// objekt štát, ktorý má kód a názov
    /// </summary>
    public class  Stat
    {

        public string KrajinaKod { get; set; }
        public string KrajinaNazov { get; set; }

        public Stat(string krajinaKod, string krajinaNazov)
        {
            KrajinaKod = krajinaKod;
            KrajinaNazov = krajinaNazov;
        }    
    }
}
