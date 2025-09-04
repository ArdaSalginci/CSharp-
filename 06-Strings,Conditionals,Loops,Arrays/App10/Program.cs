
    // OPERATORLER



   

      //  Random Sayı Üretme

         string[] takımlar = {"Galatasaray","Fenerbahçe","Beşiktaş","Trabzonspor","Başakşehir"};
           var Random = new Random();
           int sonuç = Random.Next(0,5);
           Console.WriteLine(sonuç);
           Console.WriteLine(takımlar[sonuç]) ;

           Console.WriteLine("Hesaplama yapmak için iki sayı giriniz:");
           Console.Write("1. sayı: ");
           int s1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("2. sayı: ");
           int s2 = int.Parse(Console.ReadLine());

           Console.WriteLine($"Toplama: {s1 + s2}");
           Console.WriteLine($"Çıkarma: {s1 - s2}");
           Console.WriteLine($"Çarpma: {s1 * s2}");
           Console.WriteLine($"Bölme: {(double)s1 / s2}");
           Console.WriteLine($"Mod: {s1 % s2}");

       Console.WriteLine("Ehliyetiniz var mı? evet/hayır");
           string cevap = Console.ReadLine();
           bool ehliyet = cevap ==  "evet" ||cevap == "Evet" || cevap == "EVET";
           Console.WriteLine("Yaşınızı giriniz: ");
           int yaş = Convert.ToInt32(Console.ReadLine());
           if ( ehliyet && yaş >= 18)
             Console.WriteLine("Araba kullanabilirsiniz");
           else 
           Console.WriteLine("Araba kullanamazsınız");

           string username = "arda";
           string password = "salgıncı";
           if (username == "arda") {
               if (password == "salgıncı"){

                   Console.WriteLine("Giriş yapıldı");

                 }else {

                Console.WriteLine("Şifre yanlış");}
             }
           else{ 

                Console.WriteLine("Kullanıcı adı yanlış");}
             

        int a = 3;
        int b = 3;
        if (a > b)
        {
            Console.WriteLine("a b den büyüktür");
          }
        else if (a < b)
        {
            Console.WriteLine("a b den küçüktür");
        }
        else if (a == b)
        {
            Console.WriteLine("a b ye eşittir");
        }
        else
        
            Console.WriteLine("a b den küçüktür");
        

        Console.WriteLine("Toplama işlemi için +");
        Console.WriteLine("Çıkarma işlemi için -");
        Console.WriteLine("Çarpma işlemi için *");
        Console.WriteLine("Bölme işlemi için /");
        Console.Write("Seçiminiz: ");
        var seçim = Console.ReadLine();
        Console.WriteLine("1. sayıyı giriniz: ");
        var sayı1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. sayıyı giriniz: ");
        var sayı2 = Convert.ToInt32(Console.ReadLine());

        float sonuç = 200;
        if (seçim == "+")
        {
            sonuç = sayı1 + sayı2;
        }
        else if (seçim == "-")
        {
            sonuç = sayı1 - sayı2;
        }
        else if (seçim == "*")
        {
            sonuç = sayı1 * sayı2;
        }
        else if (seçim == "/")
        {
            sonuç = sayı1 / sayı2;

        }
        else
        {
            Console.WriteLine("Geçersiz işlem");
        }
        Console.WriteLine("sonuç: "+ sonuç);

Console.Write("1.yazılı: ");
        int not1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.yazılı: ");
        int not2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("sözlü : ");
        int sözlü = Convert.ToInt32(Console.ReadLine());
        var ortalama = (not1 + not2 + sözlü) / 3; 
        int not = 0;
        if ( ortalama >= 0 && ortalama < 25) {
            not = 0;
        } else if (ortalama >= 25 && ortalama < 45){
            not = 1;
            }else if (ortalama >= 45 && ortalama < 55){
            not = 2;
            }else if (ortalama >= 55 && ortalama < 70){
            not = 3;
            }else if (ortalama >= 70 && ortalama < 85){
            not = 4;
            } else if (ortalama >= 85 && ortalama <= 100){
            not = 5;
            } else {
            Console.WriteLine("Geçersiz not");
            }
        Console.WriteLine("Not ortalamanız: " + not);
    