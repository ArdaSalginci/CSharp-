


using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

Console.WriteLine(HelperMethods.KarakteriDüzelt("ölçme ve değerlendirme testi"));


        }



    }



    class HelperMethods
    {
        public static string KarakteriDüzelt(string str)
        {
            return
            str.Replace("ı", "i")
            .Replace("ü", "u")
            .Replace("ö", "o")
            .Replace("ğ", "g")
            .Replace(" ", "-");
        }
    }
}

















