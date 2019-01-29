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
            Console.WriteLine("�dv�zl�m kedves {0} a Legyen �n is Milliomos j�t�k�ban", nev);
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
                        Console.WriteLine("Nincs ilyen men�pont!");
                        Console.ReadKey();
                    }
                    return menuPont;
                } while (menuPont <= 0 || menuPont > 4);
            }
            catch (Exception)
            {
                Console.WriteLine("Ez nem egy sz�m");
                return -1;
            }
        }

        private void menuKiir()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Legyen �n is milliomos");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Men�:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("1 - J�t�k ind�t�sa");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("2 - Dics�s�glista");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("3 - Inform�ci�k");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("4 - Kil�p�s");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 12);
            Console.Write("K�rem v�lasszon a fenti men�pontok k�z�l: ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        protected void jatekVege()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("V�ge a j�t�knak! Rossz v�laszt adt�l meg!");

        }

        protected void jatekKerdes(int i, string kerdes)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}. {1}", i + 1, kerdes);
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(" F - Felez�s");
            //Console.WriteLine(" K - K�z�ns�g Segits�ge");
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("K�rem adja mega a v�lasz�t");
            //Console.ForegroundColor = ConsoleColor.Red;
        }
        protected void jatekValaszok(string a="",string b="", string c = "", string d = "", string helyes="")
        {
            Console.WriteLine("\n\tA: {0}\n\tB: {1}\n\tC: {2}\n\tD: {3}\n\tHelyes v�lasz: {4}",a,b,c,d,helyes);
        }
        protected void JatekSeg�t(bool a, bool b,bool c)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (!a)
            {
                Console.SetCursorPosition(5, 8);
                Console.WriteLine(" F - Felez�s");
            }
            if (!b)
            {
                Console.SetCursorPosition(5, 9);
                Console.WriteLine(" K - K�z�ns�g Segits�ge");
            }
            if (!c)
            {
                Console.SetCursorPosition(5, 10);
                Console.WriteLine(" T - Telefonos seg�ts�g");
            }
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("K�rem adja meg a v�lasz�t!");

        }
        protected void Megallas(bool d)
        {
                if (!d)
                {
                    Console.SetCursorPosition(5, 12);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" M - Meg�llok");
                }
        }
        
    }
}
