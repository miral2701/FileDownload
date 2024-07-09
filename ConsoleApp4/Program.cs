using System.Net;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Download);
            t1.Start();
            Console.ReadLine();
        }
        public static void Download()
        {
            using (WebClient client = new WebClient())
            {
                string url = "https://en.wikipedia.org/wiki/Winter_white_dwarf_hamster#/media/File:PhodopusSungorus_1.jpg";
                string destinationPath = @"C:\Users\admin\Desktop\1.zip";

                try
                {
                    client.DownloadFile(url, destinationPath);
                    Console.WriteLine("Файл успешно загружен.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при загрузке файла: {ex.Message}");
                }
            }
        }
    }
}