﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FinishLine.Core
{
    public class BezecZoznam
    {

        //vytvorenie dictionary
        public static Dictionary<int, Bezec> zoznamBezcov = new Dictionary<int, Bezec>();

        /// <summary>
        /// pridávanie jednotlivých bežcov do dictionary
        /// </summary>
        /// <param name="ID">kluc</param>
        /// <param name="bezec1">objekt bežec s parametrami</param>
        public static void zoznamBezcovPridaj(int ID, Bezec bezec1)
        {
            zoznamBezcov.Add(ID, bezec1);
        }


        /// <summary>
        /// editovanie údajov o bežcoch
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="novyBezec"></param>
        public static void zoznamBezcovEdituj(int ID, Bezec novyBezec)
        {
            //uložím ho s novými údajmi
            zoznamBezcov[ID] = novyBezec;
        }


        /// <summary>
        /// Vymaže záznam v dictionary
        /// </summary>
        /// <param name="ID"></param>
        public static void zoznamBezcovVymaz(int ID)
        {
            zoznamBezcov.Remove(ID);
        }


        /// <summary>
        /// robí výpis do outputu, či sa vložili správne údaje
        /// </summary>
        public static void zoznamBezcovVypis()
        {
            foreach (var item in zoznamBezcov)
            {
                Debug.WriteLine($"Key {item.Key}");
                Debug.WriteLine($"ID: {item.Value.ID} Meno: {item.Value.Meno}Krajina: {item.Value.Krajina}Vek: {item.Value.Vek} Pohlavie: {item.Value.Pohlavie}");

            }
        }

        /// <summary>
        /// Zistuje, či už existuje dané ID v dictionary. True ak existuje
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public static bool ZistiCiIdExistuje (int id)
        {
            if (BezecZoznam.zoznamBezcov.ContainsKey(id))
            { 
                return true;
            }
            return false;
        }

        public static string BezecDajMeno(int id)
        {
            return zoznamBezcov[id].Meno;
        }


        /// <summary>
        /// Zmažem všetko čo je v dictionary aby som ho naplnil novými hodnotami
        /// </summary>
        public static void ZmazVsetkychBezcov()
        {
            zoznamBezcov.Clear();
        }
    }
}
