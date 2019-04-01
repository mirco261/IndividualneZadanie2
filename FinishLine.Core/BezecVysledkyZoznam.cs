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
        public static int VitazMiesto { get; set; } = 1;

        //vytvorenie Listu, kde si ukladám výsledky bežca
        public static List<BezecVysledky> vysledky = new List<BezecVysledky>();

        /// <summary>
        /// Pridám vysledok do zoznamu
        /// </summary>
        /// <param name="zaznam"></param>
        public static void VysledkyPridaj(BezecVysledky zaznam)
        {
            vysledky.Add(zaznam);
        }

        /// <summary>
        /// Vyhľadám si absolvované posledné kolo bežca
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
        /// Vráti mi aký bol čas zápisu predchádzajúceho kola, aby som zistil koľko trvalo aktuálne kolo
        /// </summary>
        /// <param name="id">ID bežca</param>
        /// <param name="kolo">Predchádzajúce kolo</param>
        /// <returns></returns>
        public static DateTime VysledkyCasPredchadzajucehoKola(int id, int kolo)
        {
            DateTime cas = new DateTime();
            foreach (var item in vysledky)
            {
                if (item.ID == id && item.Kolo == kolo)
                {
                    cas = item.Teraz;
                }
            }
           return cas;
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

        ///List, kde si ukladám poradie a vyhodnotenie bežca
        public static List<BezecVysledky> poradie = new List<BezecVysledky>();



        /// <summary>
        /// Pridám iba tích bežcov, čo majú poradie
        /// </summary>
        /// <param name="bezec1"></param>
        /// <param name="pocetKol"></param>
        /// <param name="pocetPoradi"></param>
        /// <returns></returns>
        public static List<BezecVysledky> PoradiePridaj(BezecVysledky bezec1 ,int pocetKol, int pocetPoradi)
        {
            //udelím miesto tomu, kto sa mi bude zhodovať v IF
                if (bezec1.Kolo == pocetKol && VitazMiesto <= pocetPoradi) 
                {
                    bezec1.Poradie = VitazMiesto;
                    poradie.Add(bezec1);
                    VitazMiesto++;
                }
            return poradie;
        }

        /// <summary>
        /// zistujem, či dané ID už je víťaz, vráti true ak už je víťaz
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool VysledkyJeUzVitaz(int id)
        {
            foreach (var item in poradie)
            {
                if (item.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Vypíšem si list víťazov
        /// </summary>
        /// <returns></returns>
        public static List<BezecVysledky> PoradieVitazov()
        {
            return poradie;
        }
    }
}
