﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Bezec
    {
        public int ID { get; set; }
        public string Meno { get; set; }
        public string Krajina { get; set; }
        public int Vek { get; set; }
        public string Pohlavie { get; set; }

        public Bezec(int id, string meno, string krajina, int vek, string pohlavie)
        {
            ID = id;
            Meno = meno;
            Krajina = krajina;
            Vek = vek;
            Pohlavie = pohlavie;
        }


    }
}
