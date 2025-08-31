
namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var soru1 = new Soru()
            {
                sorumetni = "Hangisi programlama dili değildir?",
                secenekler = new string[] { "--A)Python", "--B)C#", "--C)Java", "--D)Html" },
                cevap = "D"
            };
            var soru2 = new Soru()
            {
                sorumetni = "Hangisi en pöpüler programlama dilidir?",
                secenekler = new string[] { "--A)Python", "--B)C#", "--C)Java", "--D)Html" },
                cevap = "B"
            };
            var soru3 = new Soru()
            {
                sorumetni = "Hangisi en pöpüler web programlama platformudur?",
                secenekler = new string[] { "--A)Django", "--B)Asp.net", "--C)Spring", "--D)Python" },
                cevap = "D"
            };

            var sorular = new Soru[3] { soru1, soru2, soru3 };

            int doğru = 0;
            int yanlış = 0;
            int puan = 0;
            int doğruPuan = 5;
            foreach (var soru in sorular)
            {
                Console.WriteLine(soru.sorumetni);
                foreach (var seçenek in soru.secenekler)
                {
                    Console.WriteLine(seçenek);

                }
                Console.WriteLine("Cevabınız: (A,B,C,D)");
                var cevap = Console.ReadLine();
                if (soru.kontrolet(cevap))
                {
                    Console.WriteLine("TEBRIKLER CEVABINIZ DOĞRU");
                    doğru++;
                    puan += doğruPuan;
                }
                else
                {
                    Console.WriteLine("MAALESEF CEVABINIZ YANLIS");
                    yanlış++;
                }
            }
            Console.WriteLine($"Döğru: {doğru} Yanlış: {yanlış}");
            Console.WriteLine($"Puanınız: {puan}/15");
        }
        class Soru
        {
            // properties
            public string sorumetni { get; set; }

            public string[] secenekler { get; set; }
            public string cevap { get; set; }

            // methods
public bool kontrolet(string cevap)
{
    return this.cevap.ToLower() == cevap.ToLower(); 
}


        }

    }

}

