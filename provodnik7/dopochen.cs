using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik7
{
    internal static class dopochen
    {
        public static void dopfai()
        {
            string pt;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы выбрали создать файл, введите путь до файла:");
            pt = Convert.ToString(Console.ReadLine());
            Directory.CreateDirectory(pt + "");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void delfai()
        {
            string pt;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вы выбрали удалить файл, введите путь до файла:");
            pt = Convert.ToString(Console.ReadLine());
            System.IO.Directory.Delete(pt, true);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void dopdoc()
        {
            string pt;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вы выбрали создать документ, введите путь до файла:");
            pt = Convert.ToString(Console.ReadLine());
            System.IO.File.AppendAllText(pt, "ТЕКСТ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void deldoc()
        {
            string pt;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Вы выбрали удалить документ, введите путь до файла:");
            pt = Convert.ToString(Console.ReadLine());
            System.IO.File.Delete(pt);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
