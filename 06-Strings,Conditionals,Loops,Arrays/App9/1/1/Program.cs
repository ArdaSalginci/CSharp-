 // OPERATORLER



        // Math



           double sonuc;
           sonuc = Math.Pow(2,3);  // 2 üzeri 3
           sonuc = Math.Sqrt(25);   // 25 in karekökü
           sonuc = Math.Abs(-10);    // -10 un mutlak değeri
           sonuc = Math.Round(4.5);    // 4.5 i yuvarlar 
           sonuc = Math.Ceiling(4.5);   // 4.5 i yukarı yuvarlar
           sonuc = Math.Ceiling(4.4);   // 4.4 i yukarı yuvarlar    
           sonuc = Math.Floor(4.6);   // 4.6 i aşağı yuvarlar
           sonuc = Math.Max(10,20);   // 10 ile 20 arasında büyük olanı bulur
           sonuc = Math.Min(10,20);   // 10 ile 20 arasında küçük olanı bulur
           Console.WriteLine(sonuc);  

         Console.WriteLine("Lütfen yaşınızı giriniz: ");
         int yaş = (Convert.ToInt32(Console.ReadLine()));
           bool veli_izni = true;
           bool yaşkontrol = yaş >= 18;

           var sonuc =  yaş >= 18 || veli_izni ? ("Giriş yapabilirsiniz"):("Giriş yapamazsınız"); 
           Console.WriteLine(sonuc);
         
          string email = "arda@gmail.com";
          string username = "arda";
          string password = "123456";

         var sonuç = (email == "arda@gmail.com" || username == "arda") && (password == "123456") ? ("Giriş yapabilirsiniz") : ("Giriş yapamazsınız");
         Console.WriteLine(sonuç);
         