using System;

class Program
{
    static void Main()
    {
        //  string kursadı = " C# ";
        // var kursunuzunluğu = kursadı.Length;
        // Console.WriteLine(kursunuzunluğu);

        // var küçükharf = kursadı.ToLower();
        // Console.WriteLine(küçükharf);

        // var nokta = kursadı.EndsWith(".");
        // Console.WriteLine(nokta);

        // var ilkharf = kursadı[0];
        // Console.WriteLine(ilkharf);

        // var konum = kursadı.IndexOf("C#");
        // Console.WriteLine("konum" + konum);

        // var aralık = kursadı.Substring(0, 2);
        // Console.WriteLine(aralık);

        // var içeriyor = kursadı.Contains("C#");
        // Console.WriteLine(içeriyor);

        // var güncellenmiş = kursadı.Replace("C#", "C++");
        // Console.WriteLine(güncellenmiş);

        var rnd = new Random();
        var sayi = rnd.Next(1, 10);
        int hak = 3;
        Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz ! (Üç hakkınız vardır ve  ile 10 arasında bir sayı tahmin etmelisiniz)");
        while (hak > 0)
        {Console.Write("1-10 arası bir sayı giriniz : ");
        var tahmin = Convert.ToInt32(Console.ReadLine());
        hak--;
        if (tahmin == sayi)
        {
            Console.WriteLine("Tebrikler, doğru tahmin !");
           break; }

        else 
        {

            if (hak == 0){
                Console.WriteLine("Oyun bitti, hakkınız kalmadı.");
              break;
                }
              if (tahmin > sayi) {
                Console.WriteLine("Daha küçük bir sayı giriniz.");
                }
            else
                Console.WriteLine("Daha büyük bir sayı giriniz.");
            }
            }
        Console.WriteLine("seçilen sayı :"  + sayi);



        // Console.WriteLine("adet: ");
        // var adet = Convert.ToInt32(Console.ReadLine());
        // string[] urunler = new string[adet];
        // int i =0 ;
        // do{
        //     Console.WriteLine("ürün adı: ");
        //     urunler[i] = Console.ReadLine();
        //     i++;
        // } while(adet != i);
        // Console.WriteLine("ürünler: ");
        // for ( var a = 0; a < urunler.Length; a++) {
        //     Console.WriteLine(urunler[a]);
        // }
        }
    }