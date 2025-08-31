   using System;
using System.IO;

namespace DosyaYönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Dosya Yönetimi
 string fileName = "deneme.txt";

        // Eğer dosya yoksa oluştur
        if (!File.Exists(fileName))
        {
            File.WriteAllText(fileName, "Bu dosya yeni oluşturuldu.\n");
            Console.WriteLine(">> deneme.txt oluşturuldu.");
        }

        // Dosyadan okuma
        using (StreamReader sread1 = File.OpenText(fileName))
        {
            string? line;
            while ((line = sread1.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // Dosyaya ekleme yapma
        using (StreamWriter sw = File.AppendText(fileName))
        {
            sw.WriteLine("Arda Salgıncı C#");
            sw.WriteLine("C# Dosya Yönetimi");
        }

        Console.WriteLine(" Yeni veriler dosyaya eklendi.");

StreamReader sr = File.OpenText("deneme.txt");

var s = "";
while ((s = sr.ReadLine()) != null)
{
    Console.WriteLine(s);
}

string[] sonuç = File.ReadAllLines("deneme.txt");
Console.WriteLine(sonuç[0]);

// using (StreamWriter sw = File.CreateText("deneme.txt"))   // dosyayı baştan yazma
using (StreamWriter sw = File.AppendText("deneme.txt")) // ekleme  
{

    sw.WriteLine("merhaba");
    sw.WriteLine("ARDA");
    sw.WriteLine("SALGINCIı");

    sw.Close();
}

File.WriteAllText("deneme.txt", "merhaba"); // var olan dosya adı ise siler 
File.AppendAllText("deneme2.txt", "merhaba"); // var olan dosya yoktu create eder
Directory.CreateDirectory("temp");
Directory.CreateDirectory("temp/deneme");
Directory.CreateDirectory("temp/deneme2");

if (Directory.Exists("temp/deneme2"))
{
    Directory.CreateDirectory("temp/deneme");
}
else
{

    Console.WriteLine("silmek istediğiniz dosya bulunamamaktadır! ");
}

// Directory.Move() //taşıma

string path = @"C:\Users\ASUS\OneDrive\Masaüstü\temp\deneme";
string path2 = Directory.GetCurrentDirectory() + "/temp";
Console.Write(path);

Directory.CreateDirectory(path);


string rootPath = Directory.GetCurrentDirectory();

string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);

foreach (var dir in dirs)
{
    Console.WriteLine(dir);
}



// string source_path = @"C:\Users\ASUS\Desktop\Visual Studio Code C#\ConsoleApp\Ekran görüntüsü 2025-08-27 223607.png";
string destPath = Path.Combine(rootPath, @"C:\Users\ASUS\Desktop\Visual Studio Code C#\ConsoleApp\Ekran görüntüsü 2025-08-27 223607.png");

// 2) Klasör yoksa oluştur
if (!Directory.Exists(destPath))
    Directory.CreateDirectory(destPath);
string[] files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);
foreach (var file in files)
{


    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));

    var info = new FileInfo(file);

    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");

    if (!Directory.Exists(destPath))
    {
        Directory.CreateDirectory(destPath);
    }

    string name = Path.GetRandomFileName() + Path.GetExtension(file);
    File.Copy(file, $"{destPath}{name}");
}


        }
    }
}
