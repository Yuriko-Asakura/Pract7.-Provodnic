using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik7
{
    public class glybge
    {
        static int posit = 1;
        static string pytti;
        static string pytii;
        public string pt;
        ConsoleKeyInfo clavisha = Console.ReadKey();
        public void dkC()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("   Диск C");
            Console.WriteLine("=====================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите название файла:");
            pytti = Convert.ToString(Console.ReadLine());
            DirectoryInfo diri = new DirectoryInfo(@"" + pytti);
            Console.WriteLine("============Список файлов=============");
            foreach (var item in diri.GetDirectories())
            {
                Console.WriteLine("  " + item.FullName + " ↑↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("==============Список документов==============");
            foreach (var item in diri.GetFiles())
            {
                Console.WriteLine("  " + item.FullName + " ↑↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("Если хотите открыть файл или документ то нажмите О,если вернуться к выбору диска - то Escape, если хотите создать или удалить нажмите на Y");
            Console.WriteLine("Если хотите пойти дальше, введите F");
            clavisha = Console.ReadKey();
            while (true)
            {
                if (clavisha.Key == ConsoleKey.O)
                {
                    Console.WriteLine("Введите название файла:");
                    pytii = Convert.ToString(Console.ReadLine());
                    Process.Start(new ProcessStartInfo { FileName = pytii, UseShellExecute = true });
                    break;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    dkC();
                }
                else
                if (clavisha.Key == ConsoleKey.F)
                {
                    Console.Clear();
                    dkC();
                }
                else if (clavisha.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Program.vtr();
                }
                else
                if (clavisha.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("=====================================================================================");
                    Console.WriteLine("Если вы хотите создать файл нажмите на R, если удалить файл то на D.");
                    Console.WriteLine("Если вы хотите создать документ нажмите на X, если удалить документ, то на Z.");
                    Console.WriteLine("=====================================================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    clavisha = Console.ReadKey();
                    if (clavisha.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        dopochen.dopfai();
                        dkC();
                    }
                    else if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        dopochen.delfai();
                        dkC();
                    }
                    else if (clavisha.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        dopochen.dopdoc();
                        dkC();
                    }
                    else if (clavisha.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        dopochen.deldoc();
                        dkC();
                    }
                }
            }
        }
        public void dkD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("   Диск D");
            Console.WriteLine("=====================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите название файла:");
            pytti = Convert.ToString(Console.ReadLine());
            DirectoryInfo diri = new DirectoryInfo(@"" + pytti);
            Console.WriteLine("============Список файлов=============");
            foreach (var item in diri.GetDirectories())
            {
                Console.WriteLine("  " + item.FullName + "  ↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("==============Список документов==============");
            foreach (var item in diri.GetFiles())
            {
                Console.WriteLine("  " + item.FullName + "  ↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("Если хотите открыть файл или документ то нажмите О,если вернуться к выбору диска - то Escape, если хотите создать или удалить нажмите на Y");
            Console.WriteLine("Если хотите пойти дальше, введите F");
            clavisha = Console.ReadKey();
            while (true)
            {
                if (clavisha.Key == ConsoleKey.O)
                {
                    Console.WriteLine("Введите название файла:");
                    pytii = Convert.ToString(Console.ReadLine());
                    Process.Start(new ProcessStartInfo { FileName = pytii, UseShellExecute = true });
                    break;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    dkD();
                }
                else
                if (clavisha.Key == ConsoleKey.F)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    dkD();
                }
                else if (clavisha.Key == ConsoleKey.Escape)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Program.vtr();
                }
                else
                if (clavisha.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("=====================================================================================");
                    Console.WriteLine("Если вы хотите создать файл нажмите на R, если удалить файл то на D.");
                    Console.WriteLine("Если вы хотите создать документ нажмите на X, если удалить документ, то на Z.");
                    Console.WriteLine("=====================================================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    clavisha = Console.ReadKey();
                    if (clavisha.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        dopochen.dopfai();
                        dkD();
                    }
                    else if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        dopochen.delfai();
                        dkD();
                    }
                    else if (clavisha.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        dopochen.dopdoc();
                        dkD();
                    }
                    else if (clavisha.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        dopochen.deldoc();
                        dkD();
                    }
                }
            }
        }
        public void dkE()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("   Диск E");
            Console.WriteLine("=====================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите название файла:");
            pytti = Convert.ToString(Console.ReadLine());
            DirectoryInfo diri = new DirectoryInfo(@"" + pytti);
            Console.WriteLine("============Список файлов=============");
            foreach (var item in diri.GetDirectories())
            {
                Console.WriteLine("  " + item.FullName + "   ↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("==============Список документов==============");
            foreach (var item in diri.GetFiles())
            {
                Console.WriteLine("  " + item.FullName + "   ↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("Если хотите открыть файл или документ то нажмите О,если вернуться к выбору диска - то Escape, если хотите создать или удалить нажмите на Y");
            Console.WriteLine("Если хотите пойти дальше, введите F");
            clavisha = Console.ReadKey();
            while (true)
            {
                if (clavisha.Key == ConsoleKey.O)
                {
                    Console.WriteLine("Введите название файла:");
                    pytii = Convert.ToString(Console.ReadLine());
                    Process.Start(new ProcessStartInfo { FileName = pytii, UseShellExecute = true });
                    break;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    dkE();
                }
                else
                if (clavisha.Key == ConsoleKey.F)
                {
                    dkE();
                }
                else if (clavisha.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Program.vtr();
                }
                else
                if (clavisha.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("=====================================================================================");
                    Console.WriteLine("Если вы хотите создать файл нажмите на R, если удалить файл то на D.");
                    Console.WriteLine("Если вы хотите создать документ нажмите на X, если удалить документ, то на Z.");
                    Console.WriteLine("=====================================================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    clavisha = Console.ReadKey();
                    if (clavisha.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        dopochen.dopfai();
                        dkE();
                    }
                    else if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        dopochen.delfai();
                        dkE();
                    }
                    else if (clavisha.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        dopochen.dopdoc();
                        dkD();
                    }
                    else if (clavisha.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        dopochen.deldoc();
                        dkE();
                    }
                }
            }
        }
    }
}
