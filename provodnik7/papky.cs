using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik7
{

    public class papky
    {
        static string pyti;
        static string pytii;
        static string pytti;
        static string pytiii;
        ConsoleKeyInfo clavisha = Console.ReadKey();
        public void diskC()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("   Диск C");
            Console.WriteLine("=====================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            Console.WriteLine("============Список файлов=============");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine("  " + item.FullName + "   ↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("==============Список документов==============");
            foreach (var item in dir.GetFiles())
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
                    diskC();
                }
                else
                if (clavisha.Key == ConsoleKey.F)
                {
                    glybge glybge = new glybge();
                    glybge.dkC();
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
                        diskC();
                    }
                    else if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        dopochen.delfai();
                        diskC();
                    }
                    else if (clavisha.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        dopochen.dopdoc();
                        diskC();
                    }
                    else if (clavisha.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        dopochen.deldoc();
                        diskC();
                    }
                }
            }
        }
        public void diskD()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("   Диск D");
            Console.WriteLine("=====================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            
            DirectoryInfo dir = new DirectoryInfo(@"D:\");
            Console.WriteLine("============Список файлов=============");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine("  " + item.FullName + " ↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("==============Список документов==============");
            foreach (var item in dir.GetFiles())
            {
                Console.WriteLine("  " + item.FullName + " ↑↑↑СОЗДАН: " + item.CreationTime);
            }
            Console.WriteLine("Если хотите открыть файл или документ то нажмите О,если вернуться к выбору диска - то Escape, если хотите создать или удалить нажмите на Y");
            Console.WriteLine("Если хотите пойти дальше, введите F");
            clavisha = Console.ReadKey();
            while (true)
            {
                if (clavisha.Key == ConsoleKey.O)
                {
                        Console.WriteLine("Введите название файла:");
                        pytiii = Convert.ToString(Console.ReadLine());
                        Process.Start(new ProcessStartInfo { FileName = pytiii, UseShellExecute = true });
                }
                if (clavisha.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Program.vtr();
                }
                else
                if (clavisha.Key == ConsoleKey.F)
                {
                    glybge glybge = new glybge();
                    glybge.dkD();
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
                        diskD();
                    }
                    else if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        dopochen.delfai();
                        diskD();
                    }
                    else if (clavisha.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        dopochen.dopdoc();
                        diskD();
                    }
                    else if (clavisha.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        dopochen.deldoc();
                        diskD();
                    }
                }
            }
        }
        public void diskE()
        {
            Console.Clear();
            Console.WriteLine("   Диск E");
            DirectoryInfo dir = new DirectoryInfo(@"E:\");
            Console.WriteLine("============Список файлов=============");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine("  " + item.FullName + " ↑СОЗДАН: " + item.CreationTime );
            }
            Console.WriteLine("==============Список документов==============");
            foreach (var item in dir.GetFiles())
            {
                Console.WriteLine("  " + item.FullName + " ↑СОЗДАН: " + item.CreationTime );
            }
            Console.WriteLine("Если хотите открыть файл или документ то нажмите О,если вернуться к выбору диска - то Escape, если хотите создать или удалить нажмите на Y");
            Console.WriteLine("Если хотите пойти дальше, введите F");
            clavisha = Console.ReadKey();
            while (true)
            {
                if (clavisha.Key == ConsoleKey.O)
                {
                    Console.WriteLine("Введите название файла:");
                    pyti = Convert.ToString(Console.ReadLine());
                    Process.Start(new ProcessStartInfo { FileName = pyti, UseShellExecute = true });
                    diskE();
                }
                if (clavisha.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Program.vtr();
                }
                else
            if (clavisha.Key == ConsoleKey.F)
                {
                    Console.Clear();
                    glybge glybge = new glybge();
                    glybge.dkE();
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
                        diskE();
                    }
                    else if (clavisha.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        dopochen.delfai();
                        diskE();
                    }
                    else if (clavisha.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        dopochen.dopdoc();
                        diskE();
                    }
                    else if (clavisha.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        dopochen.deldoc();
                        diskE();
                    }
                }
            }
        }
    }
}
