using System;
using System.IO;
using IronOcr;

namespace ocr
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            int dosyaSayisi = Directory.GetFiles("img/", "*.*", SearchOption.AllDirectories).Length;
            var Ocr = new IronTesseract();
            using (var input = new OcrInput())
            { 
                input.Title = "Quarterly Report";
                for (int i = 0; i < dosyaSayisi; i++)
                {
                    input.AddImage("img/1 ("+b+").htm");
                    b++;
                }
                var Result = Ocr.Read(input);
                Result.SaveAsTextFile("AAAAA.txt");
                Environment.Exit(0);
            }
            Environment.Exit(0);
        }
    }
}
