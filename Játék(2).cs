using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace LOIM
{

    class Jatek : Menu
    {
       

        Stopwatch idomero = new Stopwatch();
        private string nev;
        private Kerdesek osszKerdes = new Kerdesek("kerdes.txt");
        private Sorkerdesek sor = new Sorkerdesek("sorkerdes.txt");
        //private bool hibaSorValasz;
        private int nehezseg = 0;
        private bool felezesHasznalva = false;
        private bool kozonsegHasznalva = false;
        private bool telefonosHasznalva=false;
        private bool elerhetomegallas = true;
        private bool megallas = false;

        public Jatek()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Legyen Ön is milliomos");
        }

        public void jatekInditas()
        {
            //Console.WriteLine("Elindult");
            int menupont;
            do
            {
                menupont = menuPontBekeres();
                switch (menupont)
                {
                    case 1:
                        idomero.Start();
                        KezdodhetAJatek();
                        break;
                    case 2:
                        dicsosegtabla();
                        Console.ReadKey();
                        break;
                    case 3:
                        informacio();
                        break;
                }
            } while (menupont != 4);
        }

        private void dicsosegtabla()
        {
            StreamReader sr = new StreamReader("dicsoseglista.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Console.WriteLine(sor);
            }
            sr.Close();
        }
        private void informacio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("A játék a következõképpen fog zajlanni \n \t A Játékot egy Sorkérdéssel fogja kezdeni, majd ha helyesen sorba rendezte õket bekerül a játékba. \n \t Ezek után 15 kérdés fog következni melyek megválaszolásáért egyre nagyobb nyereményre tehet szert.\n \t Ha minden kérdést helyesen meg válaszolt akkor 25 millió játékpénzt nyer \n \t Az 5. és a 10. kérdés megválaszolása után biztos játék nyereménnyel térhet haza.");
            Console.WriteLine();
            Console.WriteLine("Ha a szábaláyokat elolvasta kezdödhet a játék");
            Console.ReadKey();
        }
        private void KezdodhetAJatek()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Kérem adja meg a nevét :");
            Console.ForegroundColor = ConsoleColor.Gray;
            this.nev = Console.ReadLine();
            udvSzoveg(this.nev);
            Console.Clear();
            if (sorValasz())
            {
                kerdesFazis();
            }
            else
            {
                StreamWriter sw = new StreamWriter("dicsoseglista.txt", true);
                jatekVege();
                idomero.Stop();
                Console.WriteLine(" {0} Ennyi idot játszott : {1}", nev, idomero.Elapsed);
                sw.WriteLine(" {0} Ennyi idot játszott : {1}", nev,idomero.Elapsed);
                sw.Close();
            }
           
            Console.ReadKey();
        }
        private bool sorValasz()
        {
            Kerdes Sorkerdes = sor.getKerdes();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Sorkerdes.getKerdesOsszes());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kérem adja mega a válaszát");
            Console.ForegroundColor = ConsoleColor.Red;
            string valasz = Console.ReadLine().ToUpper();
            return Sorkerdes.getHelyesValasz().Equals(valasz);
        }

        private void kerdesFazis()
        {
            do
            {
                Console.Clear();
                Kerdes kerdes = osszKerdes.getKerdes(nehezseg);
                bool jo = kerdesVegrhajt(kerdes);
                if (!jo)
                {
                    telefonosHasznalva = false;
                    kozonsegHasznalva = false;
                    felezesHasznalva = false;
                    elerhetomegallas = true;
                    StreamWriter sw = new StreamWriter("dicsoseglista.txt", true);
                    jatekVege();
                    idomero.Stop();
                    Console.WriteLine(" Gratulálok {0} Ennyi szintre juttotál el : {1} idot játszottál : {2}",nev,nehezseg+1,idomero.Elapsed);
                    if (megallas && nehezseg >= 4 && nehezseg <= 9)
                    {
                        Console.WriteLine("Elvihetted az : 5-ös szint nyeremélnyét");
                        megallas = false;
                    }
                    if (megallas && nehezseg >= 9 && nehezseg <= 14)  
                    {
                        Console.WriteLine("Elvihetted az : 10-ös szint nyeremélnyét");
                        megallas = false;
                    }
                    sw.WriteLine(" Gratulálok {0} Ennyi szintre juttotál el : {1} idot játszottál : {2}", nev, nehezseg + 1, idomero.Elapsed);
                    sw.Close();
                    nehezseg = 0;
                    break;
                }         
                
            } while (nehezseg < 15);
        }
        private bool kerdesVegrhajt(Kerdes kerdes)
        {
            
            string valasz;
            bool fut = false;
            bool kozonseghasznalt = false;
            bool telefonhasznalt = false;
            jatekKerdes(nehezseg, kerdes.getKerdes());
            jatekValaszok(kerdes.getA(), kerdes.getB(), kerdes.getC(), kerdes.getD(), kerdes.getHelyesValasz());
            JatekSegít(felezesHasznalva, kozonsegHasznalva, telefonosHasznalva);

           
                fut = false;

                try
                {
                do
                {
                    if (nehezseg >= 4)
                    {
                        elerhetomegallas = false;
                        Megallas(elerhetomegallas);
                    }
                    valasz = Console.ReadLine().ToUpper(); 
                    bool jo = valasz == kerdes.getHelyesValasz();
                    if (jo)
                    {
                            kozonseghasznalt = false;
                             telefonhasznalt = false;
                        kozonseghasznalt = false;
                        Console.Clear();
                        jatekKerdes(nehezseg, kerdes.getKerdes());
                        jatekValaszok(kerdes.getA(), kerdes.getB(), kerdes.getC(), kerdes.getD(), kerdes.getHelyesValasz());
                        JatekSegít(felezesHasznalva, kozonsegHasznalva, telefonosHasznalva);
                    }
                    switch (valasz.ToString().ToLower()[0])
                    {
                        case 'f':
                            if (!felezesHasznalva)
                            {
                                felezesHasznalva = true;
                                kerdes.felezes();
                            }
                            fut = true;
                            Console.Clear();
                            jatekKerdes(nehezseg, kerdes.getKerdes());
                            jatekValaszok(kerdes.getA(), kerdes.getB(), kerdes.getC(), kerdes.getD(), kerdes.getHelyesValasz());
                            JatekSegít(felezesHasznalva, kozonsegHasznalva, telefonosHasznalva);
                            if (kozonseghasznalt)
                            {
                                kerdes.felhasznaltkozonseg();
                            }
                            if (telefonhasznalt)
                            {
                                kerdes.felhasznalttelefon();
                            }

                            break;

                        case 'k':

                            if (!kozonsegHasznalva)
                            {
                                kozonseghasznalt = true;
                                kozonsegHasznalva = true;
                                Console.Clear();
                                jatekKerdes(nehezseg, kerdes.getKerdes());
                                jatekValaszok(kerdes.getA(), kerdes.getB(), kerdes.getC(), kerdes.getD(), kerdes.getHelyesValasz());
                                JatekSegít(felezesHasznalva, kozonsegHasznalva, telefonosHasznalva);
                                kerdes.kozonseg();
                                if (telefonhasznalt)
                                {
                                    kerdes.felhasznalttelefon();
                                }
                            }

                            fut = true;

                            break;

                        case 't':
                            if (!telefonosHasznalva)
                            {
                                telefonhasznalt = true;
                                telefonosHasznalva = true;
                                Console.Clear();
                                jatekKerdes(nehezseg, kerdes.getKerdes());
                                jatekValaszok(kerdes.getA(), kerdes.getB(), kerdes.getC(), kerdes.getD(), kerdes.getHelyesValasz());
                                JatekSegít(felezesHasznalva, kozonsegHasznalva, telefonosHasznalva);
                                if (kozonseghasznalt)
                                {
                                    kerdes.felhasznaltkozonseg();
                                }
                                kerdes.telefonos();
                            }
                            fut = true;
                            break;
                        case 'm':

                                megallas = true;
                                jo = false;
                                return false;
                        default:
                            if (jo)
                            {
                                nehezseg++;
                                return true;
                            }
                            break;
                    }
                } while (fut) ;

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
