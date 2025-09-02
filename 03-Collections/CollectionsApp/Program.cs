
using System.Collections;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Collections.Generic;
using System;
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

            // ArrayList liste = new ArrayList();
            // liste.Add(10);
            // liste.Add("10");
            // liste.Add("arda");
            // liste.Add(null);
            // liste.Add(true);
            // var liste2 = new ArrayList()
            // {
            //     5,
            //     "ahmet",
            //     false,
            //     4,5,
            //     null
            // };
            // int[] sayilar = { 10, 20, 30 };
            // liste.AddRange(sayilar);
            // var eleman = (int)liste[0];
            // var isim = liste[2];


            // // insert 
            // liste.Insert(1, "arda");
            // liste.InsertRange(2, liste2);
            // // remove 
            // liste.Remove(10);
            // liste.RemoveAt(2);
            // liste.RemoveRange(2, 3);

            // // contains, indexOf
            // Console.WriteLine(liste.Contains(10));

            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }



            //         // Generic list
            //         List<int> sayilar = new List<int>();
            //         sayilar.Add(10);
            //         sayilar.Add(20);

            //         List<string> isimler = new List<string>();
            //         isimler.Add("arda");
            //         isimler.Add("ahmet");
            //         isimler.Add("ali");
            //         isimler.Add(null);
            //         List<Product> products = new List<Product>();
            //         products.Add(new Product() { Id = 1, Name = "Iphone 16", Price = 20000 });
            //         products.Add(new Product() { Id = 2, Name = "Iphone 5", Price = 200 });
            //         products.Add(new Product() { Id = 3, Name = "Iphone 8", Price = 6000 });


            //         products.Insert(products.Count, new Product() { Id = 4, Name = "Iphone 18", Price = 60000 });
            //        products.Remove(products[0]);



            //         foreach (var product in products)
            //         {
            //             Console.WriteLine(product.Name);
            //             Console.WriteLine(product.Price);

            //         }

            //     }
            // }
            // class Product
            // {

            //         public int Id { get; set; }
            //         public string Name { get; set; }
            //         public double Price { get; set; }
            //     }


            // }

            // Dictionary
            // Key-Value => plaka- şehir
            Dictionary<int, string> plakalar = new Dictionary<int, string>();

            plakalar.Add(34, "istanbul");
            plakalar.Add(35, "izmir");
            plakalar.Add(06, "ankara");
            Dictionary<int, string> sayılar = new Dictionary<int, string>()
            {
                { 1, "bir" },
                { 2, "iki" },
                { 3, "uc" },

            };

            if (plakalar.ContainsKey(50))
            {
                Console.WriteLine(plakalar[50]);
            }
            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka.Key + " - " + plaka.Value);
            }

            // update
            sayılar[1] = "one";
            sayılar[2] = "two";
            sayılar.Add(4, "four");
            // remove
            // sayılar.Remove(1);

            Console.WriteLine(sayılar); 

            //tüm sayıları yazdır
            foreach (var item in sayılar)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }


        }
    }
}

