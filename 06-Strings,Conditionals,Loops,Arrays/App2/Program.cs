using System;

class Program
{
    static void Main()
    {
    

        Console.WriteLine("ürün adedi: ");
        var adet = Convert.ToInt32(Console.ReadLine());
        string[] urunler = new string[adet];
        int i =0 ;
        do{
            Console.WriteLine("ürün adı: ");
            urunler[i] = Console.ReadLine();
            i++;
        } while(adet != i);
        Console.WriteLine("ürünler: ");
        for ( var a = 0; a < urunler.Length; a++) {
            Console.WriteLine(urunler[a]);
        }
        }
    }