using System;
using System.IO;

namespace ConDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\Windows");
            FileInfo[] fifi = di.GetFiles();

            foreach (FileInfo fificik in fifi)
            {
                Console.WriteLine(fificik.Name);
            }

            //spesifik yollar
            string belgelerim= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(belgelerim);

            DirectoryInfo myDocument = new DirectoryInfo(belgelerim);
            myDocument.CreateSubdirectory("Ahmet");
            myDocument.CreateSubdirectory("Ahmet//Deneme");
            Console.WriteLine("Dosyalar oluştu");

            Console.ReadKey();
        }
    }
}
