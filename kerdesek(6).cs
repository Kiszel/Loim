using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOIM
{
    class Kerdesek
    {
        private List<Kerdes>[] kerdesek;

        public Kerdesek(string fajlNev)
        {
            this.kerdesek = new List<Kerdes>[15];
            for (int i = 0; i < 15; i++)
            {
                kerdesek[i] = new List<Kerdes>();
            }
            try
            {
                StreamReader f = new StreamReader(fajlNev, Encoding.UTF8);

                while (!f.EndOfStream)
                {
                    string sor = f.ReadLine();

                    string[] adatok = sor.Split(';');
                    int nehezseg = Convert.ToInt32(adatok[0]);
                    string kerdes = adatok[1];
                    string a = adatok[2];
                    string b = adatok[3];
                    string c = adatok[4];
                    string d = adatok[5];
                    string helyesValasz = adatok[6];
                    string kategoria = adatok[7];

                    Kerdes k = new Kerdes(kerdes, a, b, c, d, helyesValasz, kategoria);
                    this.kerdesek[nehezseg - 1].Add(k);
                }

                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba" + e);
            }
        }
    
        public Kerdes getKerdes(int nehezseg)
        {
            Random rnd = new Random();
            int ind = rnd.Next(0, this.kerdesek[nehezseg].Count);
            return this.kerdesek[nehezseg][ind];
        }
        
    }
}
