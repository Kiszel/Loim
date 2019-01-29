using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LOIM
{
    class Sorkerdesek 
    {
        private List<Kerdes> sorkerdesek;

        public Sorkerdesek(string fajlNev)
        {
            sorkerdesek = new List<Kerdes>();
            try
            {
                StreamReader f = new StreamReader(fajlNev);
                
                while (!f.EndOfStream)
                {
                    string sor = f.ReadLine();

                    string[] adatok = sor.Split(';');
                    string kerdes = adatok[0];
                    string a = adatok[1];
                    string b = adatok[2];
                    string c = adatok[3];
                    string d = adatok[4];
                    string helyesValasz = adatok[5];
                    string kategoria = adatok[6];

                    Kerdes k = new Kerdes(kerdes, a, b, c, d, helyesValasz, kategoria);
                    this.sorkerdesek.Add(k);
                    
                }

                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba" + e);
            }
        }
        public Kerdes getKerdes()
        {
            Random rnd = new Random();
            int ind = rnd.Next(0,this.sorkerdesek.Count());
            return this.sorkerdesek[ind];
        }
    }
}
