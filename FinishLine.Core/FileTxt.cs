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
        public static string pathBezciSettings { get; set; } 
        public static string pathBezciZoznam { get; set; }
        public static string pathUmiestnenia { get; set; }
        public static string pathPreteky { get; set; }



        /// <summary>
        /// Vráti mi zlúčenú zložku so súborom do jedného stringu
        /// </summary>
        /// <param name="path"></param>
        public static void UlozCestu(string path)
        {
            pathBezciSettings = Path.Combine(path, "BezciSettings.txt");
            pathBezciZoznam = Path.Combine(path, "BezciZoznam.txt");
        }


        /// <summary>
        /// pozrie sa, či je zadaná cesta k databáze, true == existuje
        /// </summary>
        /// <returns></returns>
        public static bool JeZadanaCestaUzivatelom()
        {
            if (pathBezciSettings == null || pathBezciSettings == null)
            {
                return false;
            }
            return true;
        }

        
        /// <summary>
        /// Vráti true ak súbor existuje
        /// </summary>
        /// <returns></returns>
        public static bool SuborExistujeZoznamBezcov()
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


        /// <summary>
        /// Vráti true ak súbor existuje
        /// </summary>
        /// <returns></returns>
        public static bool SuborExistujeNastaveniaBezcov()
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


        #region Zapisovanie a načítanie nastavení programu

        /// <summary>
        /// ukladanie a načítanie natavení pretekov
        /// </summary>
        public static string NacitajNastavenia()
        {
            string[] import = File.ReadAllLines(pathBezciSettings);

            //vypíšem si do konzoly
            Debug.WriteLine($"Načítané: {import[0]}");

            //vytiahnem nastavenia na prvom riadku
            return import[0];
        }

        /// <summary>
        /// načítaj počet kôl, ktoré sú zapísané v nastaveniach
        /// </summary>
        /// <returns></returns>
        public static int NacitajPocetKol()
        {
            string[] import = File.ReadAllLines(pathBezciSettings);

            //nastavím oddelovač
            string[] zaznam = import[0].Split('\t');
            int PocetKol = int.Parse(zaznam[1]);
            return PocetKol;
        }

        /// <summary>
        /// načítaj počet víťazov, ktoré sú zapísané v nastaveniach
        /// </summary>
        /// <returns></returns>
        public static int NacitajPocetPoradi()
        {
            string[] import = File.ReadAllLines(pathBezciSettings);

            //nastavím oddelovač
            string[] zaznam = import[0].Split('\t');
            int PocetKol = int.Parse(zaznam[2]);
            return PocetKol;
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
                    file.WriteLine($"{zaznam.Key}\t{zaznam.Value.ID}\t{zaznam.Value.Meno}\t{zaznam.Value.Vek}\t{zaznam.Value.Krajina}\t{zaznam.Value.Pohlavie}");
        }

        /// <summary>
        /// Načítam z txt zoznam bežcov a vložím do listu
        /// </summary>
        public static void NacitajZoznamBezcov()
        {
            string[] import = File.ReadAllLines(pathBezciZoznam);

            //vymažem aktuálny dictionary
            BezecZoznam.ZmazVsetkychBezcov();

            foreach (var riadok in import)
            {
                //nastavím oddelovač
                string[] zaznamObezcovi = riadok.Split('\t');

                //vyplním jednotlivé values pre objekt
                int id = int.Parse(zaznamObezcovi[1]);
                string meno = zaznamObezcovi[2];
                string krajina = zaznamObezcovi[4];
                int vek = int.Parse(zaznamObezcovi[3]);
                string pohlavie = zaznamObezcovi[5];

                //vytvorím si objekt
                Bezec bezec = new Bezec(id, meno, krajina, vek, pohlavie);

                //zapíšem objekt do dictionary
                BezecZoznam.zoznamBezcovPridaj(id, bezec);

                //vypíšem si do konzoly
                BezecZoznam.zoznamBezcovVypis();
            }
        }
        #endregion

        #region Ukladanie a načítanie štatistík o behu

        /// <summary>
        /// zapisujem každého bežca do súboru txt oddelené tabulatorom (key, ID, Meno, Vek, Krajina, Pohlavie)
        /// </summary>
        public static void ZapisStatistikyOpretekoch()
        {
            using (StreamWriter file = new StreamWriter(pathPreteky))
                foreach (var zaznam in BezecVysledkyZoznam.vysledky)
                    file.WriteLine($"{zaznam.ID}\t{zaznam.Meno}\t{zaznam.Poradie}\t{zaznam.Kolo}\t{zaznam.Teraz}\t{zaznam.DlzkaKola}");
        }

        /// <summary>
        /// zapisujem každého bežca do súboru txt oddelené tabulatorom (key, ID, Meno, Vek, Krajina, Pohlavie)
        /// </summary>
        public static void ZapisStatistikyOumiestneniach()
        {
            using (StreamWriter file = new StreamWriter(pathUmiestnenia))
                foreach (var zaznam in BezecVysledkyZoznam.poradie)
                    file.WriteLine($"{zaznam.ID}\t{zaznam.Meno}\t{zaznam.Poradie}\t{zaznam.Kolo}\t{zaznam.Teraz}\t{zaznam.DlzkaKola}");
        }

        /// <summary>
        /// Vráti mi zlúčenú zložku so súborom do jedného stringu
        /// </summary>
        /// <param name="path"></param>
        public static void UlozCestuStatistik(string path)
        {
            pathUmiestnenia = Path.Combine(path, "Umiestnenia.txt");
            pathPreteky = Path.Combine(path, "Preteky.txt");
        }

        /// <summary>
        /// Načítam z txt zoznam bežcov a vložím do listu
        /// </summary>
        public static void NacitajZoznamStatistik()
        {
            string[] import = File.ReadAllLines(pathPreteky);

            //vymažem všetky záznamy v existujúcom liste
            BezecVysledkyZoznam.vysledky = new List<BezecVysledky>();

            foreach (var riadok in import)
            {
                //nastavím oddelovač
                string[] statistikaPretekyRiadok = riadok.Split('\t');

                //vyplním jednotlivé values pre objekt
                int id = int.Parse(statistikaPretekyRiadok[0]);
                string meno = statistikaPretekyRiadok[1];
                int poradie = int.Parse(statistikaPretekyRiadok[2]);
                int kolo = int.Parse(statistikaPretekyRiadok[3]);
                DateTime teraz = DateTime.Parse(statistikaPretekyRiadok[4]);
                TimeSpan dlzkaKola = TimeSpan.Parse(statistikaPretekyRiadok[5]);

                //vytvorím si objekt
                BezecVysledky bezec = new BezecVysledky(id,  meno,  teraz,  dlzkaKola,  kolo);

                //zapíšem objekt do listu vysledkov
                BezecVysledkyZoznam.VysledkyPridaj(bezec);
            }
        }

        /// <summary>
        /// Načítam z txt zoznam bežcov a vložím do listu
        /// </summary>
        public static void NacitajZoznamUmiestneni()
        {
            string[] import = File.ReadAllLines(pathUmiestnenia);

            //vymažem všetky záznamy v existujúcom liste
            BezecVysledkyZoznam.poradie = new List<BezecVysledky>();

            foreach (var riadok in import)
            {
                //nastavím oddelovač
                string[] statistikaPretekyRiadok = riadok.Split('\t');

                //vyplním jednotlivé values pre objekt
                int id = int.Parse(statistikaPretekyRiadok[0]);
                string meno = statistikaPretekyRiadok[1];
                int poradie = int.Parse(statistikaPretekyRiadok[2]);
                int kolo = int.Parse(statistikaPretekyRiadok[3]);
                DateTime teraz = DateTime.Parse(statistikaPretekyRiadok[4]);
                TimeSpan dlzkaKola = TimeSpan.Parse(statistikaPretekyRiadok[5]);

                //vytvorím si objekt
                BezecVysledky bezec = new BezecVysledky(id, meno, teraz, dlzkaKola, kolo, poradie);

                //zapíšem objekt do listu vysledkov
                BezecVysledkyZoznam.PoradiePridaj(bezec);
            }
        }

        /// <summary>
        /// Vráti true ak súbor existuje
        /// </summary>
        /// <returns></returns>
        public static bool SuborExistujeStatistikyAleboPoradie()
        {
            if (File.Exists(pathUmiestnenia) && File.Exists(pathPreteky))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
