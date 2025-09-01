
using System.Collections;
using System.Linq.Expressions;
using System.Net.Sockets;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            // Collections 
            // =>ArrayList => int, string 
            // => genetic collections 
            // => int, string, object

            ArrayList liste = new ArrayList();
            liste.Add(10);
            liste.Add("10");
            liste.Add("arda");
            liste.Add(null);
            liste.Add(true);
            var liste2 = new ArrayList()
            {
                5,
                "ahmet",
                false,
                4,5,
                null
            };
            int[] sayilar = { 10, 20, 30 };
            liste.AddRange(sayilar);
            var eleman = (int)liste[0];
            var isim = liste[2];
            Console.WriteLine(eleman);
            Console.WriteLine(isim); 
          Console.WriteLine(liste.Count);



        }
        }
    }



