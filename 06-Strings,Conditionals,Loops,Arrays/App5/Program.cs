
using System;
using System.IO;

class Program
{
    static void Main()
    {

        // Dosya yolu ve ismi
        string path = "Belgeler/not.txt";

        // Dosya oluşturma ve içine yazma
        File.WriteAllText(path, "Merhaba! Bu ilk not dosyam.");

        Console.WriteLine("Dosya oluşturuldu: " + path);

       
        File.WriteAllText(path, "Günlük başlangıç: " + DateTime.Now.ToString() + "\n");
        File.AppendAllText(path, "Arda! Saat:" + DateTime.Now.ToShortTimeString() + "\n");
        // File.AppendAllText(path, "append dediği zaman bu yazıları ekler.");
        Console.WriteLine("Dosya oluşturuldu: " + path);


      
        string içerik = File.ReadAllText(path);
        Console.WriteLine("Tüm içerik: ");
        Console.WriteLine(içerik);
        Console.WriteLine("\nSatır satır okuma: ");
        string[] satırlar = File.ReadAllLines(path);

        {
            Console.WriteLine("- " + satırlar[2]);
        }

        string kaynak = "Belgeler/notlar.txt";
        string kopya = "Belgeler/kopya.txt";
        string taşınan = "Belgeler/taşınan.txt";

        if (File.Exists(kaynak))
        {
            File.Copy(kaynak, kopya);
            Console.WriteLine("Dosya kopyalandı: " + kopya);
        }
        if (File.Exists(kopya))
        {
            File.Move(kopya, taşınan);
            Console.WriteLine("Dosya taşındı: " + taşınan);
        }
        if (File.Exists(taşınan))
        {
            File.Delete(taşınan);
            Console.WriteLine("Dosya silindi: " + taşınan);
        }



        string klasor = "Belgeler";
        Directory.CreateDirectory(klasor);
        Console.WriteLine("== Klasörler ==");
        foreach (var d in Directory.EnumerateDirectories(klasor))
        {
            Console.WriteLine("- " + d);
        }
        Console.WriteLine("== Dosyalar ==");
        foreach (var f in Directory.EnumerateFiles(klasor))
        {

            Console.WriteLine("- " + f);
        }
    }
}