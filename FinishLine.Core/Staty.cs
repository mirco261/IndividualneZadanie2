using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using KBCsv;
using FinishLine.Core;


namespace FinishLine.Core
{
    public static class Staty
    {
        public static List<Stat> krajiny = new List<Stat>();
        static string path = "countries.csv";

        //static string path = @"C:\Users\Mirco\source\repos\IndividualneZadanie2\Data\countries.csv";

        public static void NacitajZoznamStatov()
        {
            using (var streamReader = new StreamReader(path))
            using (var reader = new CsvReader(streamReader))
            {
                // the CSV file has a header record, so we read that first
                reader.ReadHeaderRecord();

                //načítavam riadok po riadku csv kodu
                while (reader.HasMoreRecords)
                {
                    reader.ValueSeparator = ';';
                    var dataRecord = reader.ReadDataRecord();

                    //pridam do listu krajín krajinu z csv
                    Stat stat1 = new Stat(dataRecord[0], dataRecord[1]);
                    krajiny.Add(stat1);

                    //vypísanie do outputu ako sa zapísali krajiny
                    //Debug.WriteLine($"Kod krajiny {stat1.KrajinaKod}, názov krajiny {stat1.KrajinaNazov}");
                }
            }
        }
    }
}
