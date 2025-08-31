


using System.Diagnostics.Contracts;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[] { "--A)Python", "--B)C#", "--C)Java", "--D)Html" }, "D");
            var soru2 = new Soru(2, "Hangisi en pöpüler programlama dilidir?", new string[] { "--A)Python", "--B)C#", "--C)Java", "--D)Html" }, "B");
            var soru3 = new Soru(3, "Hangisi en pöpüler web programlama platformudur?", new string[] { "--A)Django", "--B)Asp.net", "--C)Spring", "--D)Python" }, "D");
           Console.WriteLine(soru1);
           Console.WriteLine(soru2);
           Console.WriteLine(soru3);


                var soru4 = new Soru(20);

                Console.WriteLine(soru4.soruıd);
            }
        }
    class Soru
    {
        public Soru()
        {
            Console.WriteLine("Constructor1");
            soruıd = (new Random()).Next(1, 100);
        }

        public Soru(int soruıd)
        {
            Console.WriteLine("Constructor2");
            this.soruıd = soruıd;
        }

        public Soru(int soruıd, string sorumetni, string[] secenekler, string cevap)
        {
            this.soruıd = soruıd;
            this.sorumetni = sorumetni;
            this.secenekler = secenekler;
            this.cevap = cevap;
        }
        public int soruıd { get; set; }
        public string sorumetni { get; set; }

        public string[] secenekler { get; set; }
        public string cevap { get; set; }

        // methods
        private bool kontrolet(string cevap)
        {
            return this.cevap.ToLower() == cevap.ToLower();
        }  
               public override string ToString()
        {
            string seceneklerMetni = string.Join("\n", secenekler);
            return $"Soru {soruıd}: {sorumetni}\n{seceneklerMetni}\nCevap: {cevap}\n";
        }
    }
}
