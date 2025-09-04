//Exception 
//SystemşFormalException
//System.DivideByZeroException
//System.nullReferenceException
using System.Linq;
namespace _04_HataAyıklama
{

    class Program
    {
        static void parola_control(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                throw new Exception("Parola 6-12 karakter arasında olmalıdır.");
            }
            if (!password.Any(char.IsDigit))
            {
                throw new Exception("Parola en az 1 rakam icermelidir.");
            }
            if (!password.Any(char.IsLetter))
            
            {
                throw new Exception("Parola en az 1 harf icermelidir.");
            }



        }
        static void Main(string[] args)
        {



            Console.Write("Parolanız:");
            string parola = Console.ReadLine();
            try
            {
                parola_control(parola);
                Console.WriteLine("Parolanız onaylandı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
         




            // HATA AYIKLAMA YÖNETİMİ


            // try
            // {
            // HATA AYIKLAMA YÖNETİMİ
            //     Console.Write("1.sayı:");
            //     int sayı1 = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("2.sayı:");
            //     int sayı2 = Convert.ToInt32(Console.ReadLine());

            //     var sonuç = sayı1 / sayı2;
            //     Console.WriteLine(sonuç);

            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("sayısal verileri doğru girin.");

            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("sayı 2 0 olmamalıdır.");

            // }

            // catch (Exception exception)
            // {
            //     Console.WriteLine("bir hata oluştu");
            //     Console.WriteLine(exception.Message);

            // }





            // ExceptionHandling


            // int sayi = 10;
            // if (sayi > 5)
            // {
            //     throw new Exception("Sayı 5 den buyuk olamaz.");
            // }









        }
    }
}
     