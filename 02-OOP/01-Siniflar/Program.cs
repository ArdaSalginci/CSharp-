
namespace CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba btk");
            //class --> object 

            öğrenci ogr1 = new öğrenci();
            ogr1.öğrencino = " 100";
            ogr1.adsoyad = "arda salgıncı";
            ogr1.sube = "1/A";

            öğrenci ogr2 = new öğrenci();
            ogr2.öğrencino = " 80";
            ogr2.adsoyad = "erhan salgıncı";
            ogr2.sube = "2/A";

            öğrenci ogr3 = new öğrenci();
            ogr3.öğrencino = " 85";
            ogr3.adsoyad = "dilek salgıncı";
            ogr3.sube = "8/A";

            öğrenci[] öğrenciler = new öğrenci[3];

            öğrenciler[0] = ogr1;
            öğrenciler[1] = ogr2;
            öğrenciler[2] = ogr3;

            foreach (var öğrenci in öğrenciler)
            {
                Console.WriteLine($"{öğrenci.öğrencino} numaralı öğrencinin adı {öğrenci.adsoyad} ve subesi {öğrenci.sube}");

            }
        }
     }
     class öğrenci
  { // property --> string, int

         public string öğrencino { get; set; }
         public string adsoyad { get; set; }
         public string sube { get; set; }
// methods 




    }
}

// ConsoleApp --> Program, öğrenci
// System --> Console
// System.IO --> File, Directory, path
