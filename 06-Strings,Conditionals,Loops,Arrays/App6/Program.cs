using System;

class Program
{
    static void Main()
    {
        string[] kurum = { "BTK", "Akademi" };
        Console.WriteLine(kurum[0]);
        string[] adlar = new string[3];
        adlar[0] = "Ahmet";
        adlar[1] = "Mehmet";
        adlar[2] = "Ayşe";
        Console.WriteLine(adlar[0]);
        Console.WriteLine(adlar[1]);
        Console.WriteLine(adlar[2]);



        var kursadı = " Öğrenci notları C# Dersleri ".Split();
        string[] isimler = new string[5];
        isimler[0] = "Arda";
        isimler[1] = "Ahmet";
        isimler[2] = "Ayşe";
        isimler[3] = "Murat";
        isimler[4] = "Mehmet";


        int[] notlar = new int[5];
        notlar[0] = 100;
        notlar[1] = 200;
        notlar[2] = 300;
        notlar[3] = 400;
        notlar[4] = 500;
        Console.WriteLine($"{isimler[0]} isimli öğrencinin notu: {notlar[0]}");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");





        Console.WriteLine("DİZİ METOTLARI");

        // Dizi Metotları ( Array Methods)



        string[] şehirler = { "İstanbul", "İzmir", "Ankara" };
        int[] plakalar = { 34, 35, 06 };
        şehirler[0] = ("antep");
        şehirler.SetValue("antep", 0); // 0. indexteki değeri değiştirir
        Console.WriteLine(şehirler.GetValue(1));
        Console.WriteLine(şehirler.Length);
        Console.WriteLine(Array.IndexOf(şehirler, "İstanbul"));

        Array.Sort(şehirler);  // harf sıralaması yapar
        Array.Sort(plakalar);
        Console.WriteLine(şehirler.GetValue(0)); // 0. indexteki değeri getirir
        Console.WriteLine(plakalar.GetValue(1));
        Array.Reverse(plakalar);
         Array.Clear(şehirler);
    }
}