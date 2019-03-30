using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using FinishLine;

namespace FinishLine.Core
{
    public static class FileTxt
    {
        //tu sa budu ukladať a načítavať nastavenia programu
        static string pathBezciSettings = @"C:\Users\Public\Documents\BezciSettings.txt";
        static string pathBezciZoznam = @"C:\Users\Public\Documents\BezciZoznam.txt";
        static string s;

        /// <summary>
        /// Vráti true ak súbor existuje
        /// </summary>
        /// <returns></returns>
        public static bool SuborExistujeNastavenia()
        {
            if (File.Exists(pathBezciSettings))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Vráti true ak súbor existuje
        /// </summary>
        /// <returns></returns>
        public static bool SuborExistujeZoznam()
        {
            if (File.Exists(pathBezciZoznam))
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
            string[] import = System.IO.File.ReadAllLines(pathBezciSettings);

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
            File.WriteAllText(pathBezciSettings, String.Empty);

            //zapíšem nastavenai do path
            using (StreamWriter sw = File.AppendText(pathBezciSettings))
            {
                sw.Write($"{dlzkaKola}\t{pocetKol}\t{pocetMiestVitazov}");
                sw.Close();

                //preverím v outpute čo bolo  zapísané
                Debug.WriteLine($"Zapísané: {dlzkaKola}, {pocetKol}, {pocetMiestVitazov}");
            }
        }
        #endregion

        #region Zapisovanie do txt zoznam bežcov a ich načítanie

        /// <summary>
        /// zapisujem každého bežca do súboru txt oddelené tabulatorom (key, ID, Meno, Vek, Krajina, Pohlavie)
        /// </summary>
        public static void ZapisZoznamBezcov()
        {
            using (StreamWriter file = new StreamWriter(pathBezciZoznam))
                foreach (var zaznam in BezecZoznam.zoznamBezcov)
                    file.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", zaznam.Key, zaznam.Value.ID, zaznam.Value.Meno, zaznam.Value.Vek, zaznam.Value.Krajina, zaznam.Value.Pohlavie);
        }


        public static void NacitajZoznamBezcov()
        {
            string[] import = System.IO.File.ReadAllLines(pathBezciZoznam);

            //vymažem aktuálny dictionary
            BezecZoznam.ZmazVsetkoVdictionary();

            foreach (var item in import)
            {
                //nastavím oddelovač
                string[] zaznamObezcovi = item.Split('\t');

                //vyplním jednotlivé values pre objekt
                int key = int.Parse(zaznamObezcovi[0]);
                int id = int.Parse(zaznamObezcovi[1]);
                string meno = zaznamObezcovi[2];
                string krajina = zaznamObezcovi[4];
                int vek = int.Parse(zaznamObezcovi[3]);
                string pohlavie = zaznamObezcovi[5];

                //vytvorím si objekt
                Bezec bezec1 = new Bezec(id, meno, krajina, vek, pohlavie);

                //zapíšem objekt do dictionary
                BezecZoznam.zoznamBezcovPridaj(id, bezec1);

                //vypíšem si do konzoly
                BezecZoznam.zoznamBezcovVypis();
            }
        }
        #endregion
    }
}
