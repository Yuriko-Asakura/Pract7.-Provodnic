using Microsoft.VisualBasic.FileIO;
using System.Drawing;

namespace provodnik7
{
    internal class Program
    {
       static void Main()
        {
            Console.WriteLine("Добро пожаловать в проводник! Выюберите диск с которым хотите работать!");
            Console.WriteLine("       Список дисков"); 
            foreach (var drive in DriveInfo.GetDrives())
            {
                Console.WriteLine("   Имя диска: " + drive.Name);
                Console.WriteLine("  Свободно {0} ГБ из {1} ГБ", drive.TotalFreeSpace / 1073741824, drive.TotalSize / 1073741824);
            }
                strelka strelka = new strelka(1,12);
        }
        public static void vtr()
        {
            Console.WriteLine("ДДобро пожаловать в проводник! Выюберите диск с которым хотите работать!");
            Console.WriteLine("       Список дисков");
            foreach (var drive in DriveInfo.GetDrives())
            {
                Console.WriteLine("   Имя диска: " + drive.Name);
                Console.WriteLine("  Свободно {0} ГБ из {1} ГБ", drive.TotalFreeSpace / 1073741824, drive.TotalSize / 1073741824);
            }
            strelka strelka = new strelka(1,12);
        }
    }
}