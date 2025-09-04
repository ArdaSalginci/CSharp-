

using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Oluşturmak istediğiniz dosyanın adını yazınız: ");
        string dosyaAdi = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(dosyaAdi))
        {
            dosyaAdi = "Belgeler";

        }
        if (Directory.Exists(dosyaAdi))
        {
            Console.WriteLine("Bu isimde bir dosya zaten var." + dosyaAdi);
        }
        else{
            Directory.CreateDirectory(dosyaAdi);
            Console.WriteLine("Dosya oluşturuldu." + dosyaAdi);
        }

    }
}