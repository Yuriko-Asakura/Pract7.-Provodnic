using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik7
{

    public class strelka
    {
       private static int posit = 1;
        static int i;
        static int a;
        public strelka(int min,int max )
        {
            i = min;
            a = max;
            Console.WriteLine("  ");
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    if (posit < max)
                    {
                        Console.WriteLine("  ");
                        Console.WriteLine("->");
                        posit++;
                    }
                }
                else
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    if (posit > min)
                    {
                        posit--;
                        Console.WriteLine("->");
                        Console.WriteLine("  ");
                    }
                }
                Console.WriteLine("  ");
                Console.SetCursorPosition(0, posit);
                clavisha = Console.ReadKey();
            }
            pad();
        }
       private static void pad()
        {
            papky papky = new papky();
            ConsoleKeyInfo clavisha = Console.ReadKey();
            if (posit == 2)
            {
                papky.diskC();
            }
            else
            if (posit == 4)
            {
                papky.diskD();
            }
            else
            if (posit == 6)
            {
                papky.diskE();
            }
        }
    }
}
