
    // OPERATORLER



   
        //arda salgıncı bilgisayar mühendisi mi olacak, yoksa yazılım mı olacak yoksa, inşaat mühendisi mi olacak
       // 1-4 arası sayı üret
        string[] dizi = { "Bilgisayar Mühendisi", "İnşaat Mühendisi", "İKİSİDE" };

        Random random = new Random();

         int sayı = random.Next(0, 3);
         Console.WriteLine(dizi[sayı]);

        Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
        
        int gün = (int)DateTime.Now.DayOfWeek; 

        switch (gün)
        {
            case 0:
                Console.WriteLine("Pazartesi");
                break;
            case 1:
                Console.WriteLine("Salı");
                break;
            case 2:
                Console.WriteLine("Çarşamba");
                break;
            case 3:
                Console.WriteLine("Perşembe");
                break;
            case 4:
                Console.WriteLine("Cuma");
                break;
            case 5:
                Console.WriteLine("Cumartesi");
                break;
            case 6:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz gün");
                break;
        }
        Console.Write("Sayı giriniz: ");
        int sayı = Convert.ToInt32(Console.ReadLine());
        var sonuç = (sayı % 2 == 0) ? sayı > 0 ? "Pozitif Çift Sayı" : "Negatif Çift Sayı" :
                                      sayı > 0 ? "Pozitif Tek Sayı" : "Negatif Tek Sayı";
        Console.WriteLine(sonuç);
      
        
    






