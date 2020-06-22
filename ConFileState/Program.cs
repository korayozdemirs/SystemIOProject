using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFileState
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo di = new DirectoryInfo("C:\\");
            //di.CreateSubdirectory("Deneme");

            //FileStream fs = new FileStream("C:\\Deneme\\yms9300.txt", FileMode.Create, FileAccess.Write);

            //StreamWriter sw = new StreamWriter(fs);
            ////Write tyan yana yazar writeline yaz alt satıra geç
            //sw.WriteLine("Ahmet Taş");
            //sw.WriteLine("Taş Ailesi");
            //sw.WriteLine("Taş gibi aile kaya gibiler");

            //sw.Close();
            //fs.Close();
            //Console.WriteLine("Dosya oluşturuldu içine yazıldı");


            //Doısya hakkında bilgi almak için
            FileInfo fifi = new FileInfo("C:\\Deneme\\yms9300.txt");
            Console.WriteLine("Erişim Tarihi" + fifi.LastAccessTime);
            Console.WriteLine("Test" + fifi.LastWriteTime);

            Console.WriteLine("**************************");

            FileStream fs = new FileStream("C:\\Deneme\\yms9300.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //Console.WriteLine(sr.ReadToEnd());
            while (sr.Peek() != -1)
            {
                string satir = sr.ReadLine();
                Console.WriteLine(satir);
            }

            sr.Close();
            fs.Close();

            Console.ReadKey();

        }
    }
}
