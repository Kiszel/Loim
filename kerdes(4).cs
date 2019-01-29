using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOIM
{
    class Kerdes
    {
        private Random rnd = new Random();
        private string kerdes;
        private string A, B, C, D;
        private string helyesValasz;
        private string kategoria;

        private int Aszazalek ;
        private int Bszazalek ;
        private  int Cszazalek ;
        private  int Dszazalek ;
        private int szazalekosszes;

        private int esely;
        private int random;

        public string getKerdes()
        {
            return this.kerdes;
        }

        public string getA()
        {
            return this.A;
        }
        public string getB()
        {
            return this.B;
        }
        public string getC()
        {
            return this.C;
        }
        public string getD()
        {
            return this.D;
        }

        public string getHelyesValasz()
        {
            return this.helyesValasz;
        }
        public string getKategoria()
        {
            return this.kategoria;
        }

        public Kerdes(string kerdes, string a, string b, string c, string d, string helyesValasz, string kategoria)
        {
            this.kerdes = kerdes;
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.helyesValasz = helyesValasz.ToUpper();
            this.kategoria = kategoria;
        }
        public void telefonos()
        {
            esely = rnd.Next(0, 100);
            string ideiglenes = "ABCD";
            if (esely > 30)
            {
                Console.WriteLine("A helyes valasz : {0}", helyesValasz);
                ideiglenes.Replace(helyesValasz, "");
            }
            else
            {
                random = rnd.Next(3);
                if (random == 0)
                {
                    Console.WriteLine("A helyes valasz :{0}", ideiglenes[random]);
                }
                if (random == 1)
                {
                    Console.WriteLine("A helyes valasz :{0}", ideiglenes[random]);
                }
                if (random == 2)
                {
                    Console.WriteLine("A helyes valasz :{0}", ideiglenes[random]);
                }
            }
        }
        public void felhasznalttelefon()
        {
            string ideiglenes = "ABCD";
            if (esely > 30)
            {
                Console.WriteLine("A helyes valasz : {0}", helyesValasz);
                ideiglenes.Replace(helyesValasz, "");
            }
            else
            {
                if (random == 0)
                {
                    Console.WriteLine("A helyes valasz :{0}", ideiglenes[random]);
                }
                if (random == 1)
                {
                    Console.WriteLine("A helyes valasz :{0}", ideiglenes[random]);
                }
                if (random == 2)
                {
                    Console.WriteLine("A helyes valasz :{0}", ideiglenes[random]);
                }
            }
        }
            public void felhasznaltkozonseg()
            {
            if ("A"==helyesValasz)
            {
                Console.WriteLine("A:{0}%", Aszazalek);
                Console.WriteLine("B:{0}%", Bszazalek);
                Console.WriteLine("D:{0}%", Dszazalek);
                Console.WriteLine("C:{0}%", szazalekosszes);
            }
            if ("B"==helyesValasz)
            {
                Console.WriteLine("B:{0}%", Bszazalek);
                Console.WriteLine("A:{0}%", Aszazalek);
                Console.WriteLine("D:{0}%", Dszazalek);
                Console.WriteLine("C:{0}%", szazalekosszes);

            }
            if ("C"==helyesValasz)
            {
                Console.WriteLine("C:{0}%", Cszazalek);
                Console.WriteLine("B:{0}%", Bszazalek);
                Console.WriteLine("D:{0}%", Dszazalek);
                Console.WriteLine("A:{0}%", szazalekosszes);
            }
            if ("D"==helyesValasz)
            {
                Console.WriteLine("D:{0}%", Dszazalek);
                Console.WriteLine("B:{0}%", Bszazalek);
                Console.WriteLine("A:{0}%", Aszazalek);
                Console.WriteLine("C:{0}%", szazalekosszes);
            }         
            }
        public void kozonseg()
        {
            Aszazalek = 0;
            Bszazalek = 0;
            Cszazalek = 0;
            Dszazalek = 0;
            szazalekosszes = 100;
            bool helyes = false;
            while (!helyes)
            {
                if ("A"==helyesValasz)
                {
                    Aszazalek = rnd.Next(30, 70);
                    Console.WriteLine("A:{0}%",Aszazalek);
                    helyes = true;
                    szazalekosszes -= Aszazalek;
                }
                if ("B" == helyesValasz)
                {

                    Bszazalek = rnd.Next(30, 70);
                    Console.WriteLine("B:{0}%", Bszazalek);
                    helyes = true;
                    szazalekosszes -= Bszazalek;
                }
                if ("C"== helyesValasz)
                {

                    Cszazalek = rnd.Next(30, 70);
                    Console.WriteLine("C:{0}%", Cszazalek);
                    helyes = true;
                    szazalekosszes -= Cszazalek;
                }
                if ("D"== helyesValasz)
                {

                    Dszazalek = rnd.Next(30, 70);
                    Console.WriteLine("D:{0}%", Dszazalek);
                    helyes = true;
                    szazalekosszes -= Dszazalek;
                }
            }

            if (Aszazalek !=0 && Bszazalek == 0 && Dszazalek == 0 && Cszazalek == 0 )
            {
                
                Bszazalek =rnd.Next(0, szazalekosszes);
                Console.WriteLine("B:{0}%",Bszazalek);
                szazalekosszes -= Bszazalek;
                Dszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("D:{0}%", Dszazalek);
                szazalekosszes -= Dszazalek;
              //  Cszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("C:{0}%", szazalekosszes);
                //szazalekosszes -= Cszazalek;
            }
            if (Bszazalek != 0 && Aszazalek==0 && Dszazalek==0 && Cszazalek ==0)
            {
                Aszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("A:{0}%", Aszazalek);
                szazalekosszes -= Aszazalek;
                Dszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("D:{0}%", Dszazalek);
                szazalekosszes -= Dszazalek;
               // Cszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("C:{0}%", szazalekosszes);
                //szazalekosszes -= Cszazalek;
            }
            if (Cszazalek != 0 && Aszazalek == 0 && Dszazalek == 0 && Bszazalek == 0)
            {
                Bszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("B:{0}%", Bszazalek);
                szazalekosszes -= Bszazalek;
                Dszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("D:{0}%", Dszazalek);
                szazalekosszes -= Dszazalek;
               // Aszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("A:{0}%",szazalekosszes);
              //  szazalekosszes -= Aszazalek;
            }

            if (Dszazalek != 0 && Bszazalek == 0 && Aszazalek == 0 && Cszazalek == 0 )
            {
                Bszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("B:{0}%", Bszazalek);
                szazalekosszes -= Bszazalek;
                Aszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("A:{0}%", Aszazalek);
                szazalekosszes -= Aszazalek;
                //Cszazalek = rnd.Next(0, szazalekosszes);
                Console.WriteLine("C:{0}%",szazalekosszes);
               // szazalekosszes -= Cszazalek;
            }

        }
        public void felezes()
        {
            string temp = "ABCD";
            temp = temp.Replace(helyesValasz, "");
            //Random rnd = new Random();           
            
            int i = 0;
            while(i < 2)
            {
                int valasz = rnd.Next(temp.Length);
                switch (temp[valasz])
                {
                    case 'A':
                        temp = temp.Replace(temp[valasz].ToString(), "");
                        this.A = "";
                        break;
                    case 'B':
                        temp = temp.Replace(temp[valasz].ToString(), "");
                        this.B = "";
                        break;
                    case 'C':
                        temp = temp.Replace(temp[valasz].ToString(), "");
                        this.C = "";
                        break;
                    case 'D':
                        temp = temp.Replace(temp[valasz].ToString(),"");
                        this.D = "";
                        break;
                }
                i++;
            }
            Console.WriteLine(temp);


        }

        public string getKerdesOsszes()
        {
            return String.Format("{0}-[{1}]\n\tA: {2}\n\tB:{3}\n\tC:{4}\n\tD:{5}\n\tHelyes válasz: {6}",
                this.kerdes,
                this.kategoria,
                this.A,
                this.B,
                this.C,
                this.D,
                this.helyesValasz
                );
        }


    }
}
