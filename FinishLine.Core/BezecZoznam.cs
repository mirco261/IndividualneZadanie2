using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FinishLine
{
    public class BezecZoznam
    {

        public static Dictionary<int, Bezec> zoznamBezcov = new Dictionary<int, Bezec>();

        public static void zoznamBezcovPridaj(int ID, Bezec bezec1)
        {
            zoznamBezcov.Add(ID, bezec1);
        }

        public static void zoznamBezcovVypis()
        {
            foreach (var item in zoznamBezcov)
            {
                Debug.WriteLine($"Key {item.Key}");
                Debug.WriteLine($"Value {item.Value}");

            }
        }




    }
}
