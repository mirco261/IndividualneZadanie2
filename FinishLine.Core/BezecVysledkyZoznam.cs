using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FinishLine.Core
{
    public class BezecVysledkyZoznam
    {
        //vytvorenie Stack
        public static List<BezecVysledky> vysledky = new List<BezecVysledky>();

        public static void VysledkyPridaj(BezecVysledky zaznam)
        {
            vysledky.Add(zaznam);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int VysledkyHladajKoloBezca(int id)
        {
            int maxKolo = 0;
            foreach (var item in vysledky)
            {
                //hladam najvyššie číslo Kola pre vybrané ID
                if (item.Kolo > maxKolo && item.ID == id)
                {
                    maxKolo = item.Kolo;
                }
            }
            return maxKolo;
        }

        /// <summary>
        /// zobraz výsledky v debug outpute
        /// </summary>
        public static void VysledkyZobraz()
        {
            foreach (var item in vysledky)
            {
                Debug.WriteLine($"Zapísané ID{item.ID} Meno{item.Meno} {item.Kolo}, {item.DlzkaKola}");

            }
        }

        public static List<BezecVysledky> vysledkyTop(int pocetKol, int pocetPoradi)
        {
            List<BezecVysledky> newList = new List<BezecVysledky>();
            foreach (var item in vysledky)
            {
                if (item.Kolo == pocetKol && newList.Count <= pocetPoradi-1)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

    }
}
