
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
           

            // insert 
            liste.Insert(1, "arda");
            liste.InsertRange(2, liste2);
            // remove 
            liste.Remove(10);
            liste.RemoveAt(2);
            liste.RemoveRange(2, 3);

            // contains, indexOf
            Console.WriteLine(liste.Contains(10));


            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
        }
    }



