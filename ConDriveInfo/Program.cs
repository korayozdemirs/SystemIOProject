using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] suruculer = DriveInfo.GetDrives();

            foreach (var surucu in suruculer)
            {
                if (surucu.IsReady)
                {
                    Console.WriteLine(surucu.Name);
                    Console.WriteLine("Toplam Alan = " + surucu.TotalSize);
                    Console.WriteLine("Boş Alan = " + surucu.TotalFreeSpace);
                    Console.WriteLine("***********************************");
                }
            }
            DirectoryInfo di = new DirectoryInfo(".");
            Console.WriteLine(di.FullName);

            DirectoryInfo klasor = new DirectoryInfo("C:\\YMS9103");
            if (!klasor.Exists)
            {
                klasor.Create();
                Console.WriteLine("Klasör oluşturuldu");
            }

            Console.WriteLine("Ozellikleri =  " + klasor.Attributes);
            Console.WriteLine("Oluşturlma Tarihi " + klasor.CreationTime);
            Console.WriteLine("Klasor Adi " + klasor.Name);
            Console.WriteLine("Klasor FullName = " + klasor.FullName);
            Console.WriteLine("ANa Dizin = " + klasor.Root);
            Console.WriteLine("Son Erişim Tarihi = " + klasor.LastAccessTime);


            Console.ReadKey();
        }
    }
}
