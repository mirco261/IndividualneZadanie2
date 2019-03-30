using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FinishLine.Core
{
    public static class FileTxt
    {
        //tu sa budu ukladať a načítavať nastavenia programu
        static string path = @"C:\Users\Public\Documents\BezciSettings.txt";
        static string s;

        /// <summary>
        /// Vráti true ak súbor existuje
        /// </summary>
        /// <returns></returns>
        public static bool SuborExistuje()
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Zapisovanie a načítanie nastavení programu


        /// <summary>
        /// ukladanie a načítanie natavení pretekov
        /// </summary>
        public static string NacitajNastavenia()
        {
            string[] import = System.IO.File.ReadAllLines(path);

            //vypíšem si do konzoly
            Debug.WriteLine($"Načítané: {import[0]}");

            //vytiahnem nastavenia na prvom riadku
            return import[0];

        }

        /// <summary>
        /// Zapisujem do txt nastavenia odoslané cez formulár
        /// </summary>
        /// <param name="dlzkaKola"></param>
        /// <param name="pocetKol"></param>
        /// <param name="PocetMiestVitazov"></param>
        public static void ZapisNastavenia(decimal dlzkaKola, int pocetKol, int pocetMiestVitazov)
        {
            //vyprázdnim texták
            File.WriteAllText(path, String.Empty);

            //zapíšem nastavenai do path
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write($"{dlzkaKola}\t{pocetKol}\t{pocetMiestVitazov}");
                sw.Close();

                //preverím v outpute čo bolo  zapísané
                Debug.WriteLine($"Zapísané: {dlzkaKola}, {pocetKol}, {pocetMiestVitazov}");
            }


        }
        #endregion


    }
}
