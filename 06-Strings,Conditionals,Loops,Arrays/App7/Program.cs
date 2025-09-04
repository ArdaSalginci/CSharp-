
        // Array Slicing


           string[] şehirler = {"İstanbul","İzmir","Ankara"};
         foreach (var şehir in şehirler[0..3]) 
             Console.WriteLine(şehir);     


         string[] öğrenciler = { "Ahmet", "Mehmet", "Ayşe" };
         int[,] öğrenciNotları = new int[3, 3];

         öğrenciNotları[0, 0] = 500 ;
         öğrenciNotları[0, 1] = 100 ; 
         öğrenciNotları[0, 2] = 200 ;

         öğrenciNotları[1, 0] = 300 ;
         öğrenciNotları[1, 1] = 400 ;
         öğrenciNotları[1, 2] = 500 ;

         öğrenciNotları[2, 0] = 600 ;
         öğrenciNotları[2, 1] = 700 ;
         öğrenciNotları[2, 2] = 800 ;


       var ortalama1 = ((öğrenciNotları[0, 0]) + (öğrenciNotları[0, 1]) + (öğrenciNotları[0, 2])) / 3;
       var ortalama2 = ((öğrenciNotları[1, 0]) + (öğrenciNotları[1, 1]) + (öğrenciNotları[1, 2])) / 3;
       var ortalama3 = ((öğrenciNotları[2, 0]) + (öğrenciNotları[2, 1]) + (öğrenciNotları[2, 2])) / 3;

         Console.WriteLine($"{öğrenciler[0]} isimli öğrencinin not ortalaması: {ortalama1}");
         Console.WriteLine($"{öğrenciler[1]} isimli öğrencinin not ortalaması: {ortalama2}");
         Console.WriteLine($"{öğrenciler[2]} isimli öğrencinin not ortalaması: {ortalama3}");

         Console.Write("Adınız: ");
         string ad = Console.ReadLine();

         Console.Write("Soyadınız: ");
         string soyad = Console.ReadLine();

         string tamAd = ad + " " + soyad;

         Console.WriteLine("Tam adınız: " + tamAd);
         Console.WriteLine("Karakter sayısı: " + tamAd.Length);
         Console.WriteLine("Küçük harfli hali: " + tamAd.ToLower());
         Console.WriteLine("ad soyad yer değiştirme: " + tamAd.Replace(ad, soyad));
       
