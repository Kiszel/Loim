using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOIM
{
    class Menu 
    {
        protected void udvSzoveg(string nev)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("Üdvözlöm kedves {0} a Legyen ön is Milliomos játékában", nev);
            //Console.Clear();
        }
        protected int menuPontBekeres()
        {
            int menuPont;

                menuKiir();
            try
            {
                do
                { 
                    menuPont = Convert.ToInt32((Console.ReadLine()));
                    if (menuPont < 0 || menuPont > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("Nincs ilyen menüpont!");
                        Console.ReadKey();
                    }
                    return menuPont;
                } while (menuPont <= 0 || menuPont > 4);
            }
            catch (Exception)
            {
                Console.WriteLine("Ez nem egy szám");
                return -1;
            }
        }

        private void menuKiir()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Legyen Ön is milliomos");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Menü:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("1 - Játék indítása");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("2 - Dicsõséglista");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("3 - Információk");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("4 - Kilépés");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 12);
            Console.Write("Kérem válasszon a fenti menüpontok közül: ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        protected void jatekVege()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vége a játéknak! Rossz választ adtál meg!");

        }

        protected void jatekKerdes(int i, string kerdes)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}. {1}", i + 1, kerdes);
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(" F - Felezés");
            //Console.WriteLine(" K - Közönség Segitsége");
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Kérem adja mega a válaszát");
            //Console.ForegroundColor = ConsoleColor.Red;
        }
        protected void jatekValaszok(string a="",string b="", string c = "", string d = "", string helyes="")
        {
            Console.WriteLine("\n\tA: {0}\n\tB: {1}\n\tC: {2}\n\tD: {3}\n\tHelyes válasz: {4}",a,b,c,d,helyes);
        }
        protected void JatekSegít(bool a, bool b,bool c)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (!a)
            {
                Console.SetCursorPosition(5, 8);
                Console.WriteLine(" F - Felezés");
            }
            if (!b)
            {
                Console.SetCursorPosition(5, 9);
                Console.WriteLine(" K - Közönség Segitsége");
            }
            if (!c)
            {
                Console.SetCursorPosition(5, 10);
                Console.WriteLine(" T - Telefonos segítség");
            }
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kérem adja meg a válaszát!");

        }
        protected void Megallas(bool d)
        {
                if (!d)
                {
                    Console.SetCursorPosition(5, 12);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" M - Megállok");
                }
        }
        
    }
}
