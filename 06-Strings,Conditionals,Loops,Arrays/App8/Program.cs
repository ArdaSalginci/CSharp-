


           Console.Write("Adınız: ");
           string ad = Console.ReadLine();

           DateTime bugun = DateTime.Now;
           Console.WriteLine("Merhaba " + ad + "! Bugünün tarihi: " + bugun.ToString("dd.MM.yyyy"));
           Console.WriteLine("doğum yılınızı giriniz: ");
           int doğumyılı = Convert.ToInt32(Console.ReadLine());
           int yaş = bugun.Year - doğumyılı;
           Console.WriteLine("Yaşınız: " + yaş);
     

        string[] renkler = { "Kırmızı", "Mavi", "Yeşil", "Sarı" };

        Console.WriteLine("Renkler:");
        foreach (string renk in renkler)
        {
         Console.WriteLine("- " + renk);
        }
        //3 elemanlı dizi tanımlıyoruz

         string[] arkadaşlar = new string[3];

         Console.Write("en sevdiğiniz 1. arkadaşınızı giriniz: ");
         arkadaşlar[0] = Console.ReadLine();

         Console.Write("en sevdiğiniz 2. arkadaşınızı  giriniz: ");
         arkadaşlar[1] = Console.ReadLine();

         Console.Write("en sevdiğiniz 3. arkadaşınızı giriniz: ");
         arkadaşlar[2] = Console.ReadLine();

         //Girilen arkadaşlari ekrana yazdırıyoruz
         Console.WriteLine("Favori arkadaşlariniz:");
         Console.WriteLine("- " + arkadaşlar[0]);
         Console.WriteLine("- " + arkadaşlar[1]);
         Console.WriteLine("- " + arkadaşlar[2]);
       