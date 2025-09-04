 string kursadı = " C# ";
        var kursunuzunluğu = kursadı.Length;
        Console.WriteLine(kursunuzunluğu);

        var küçükharf = kursadı.ToLower();
        Console.WriteLine(küçükharf);

        var nokta = kursadı.EndsWith(".");
        Console.WriteLine(nokta);

        var ilkharf = kursadı[0];
        Console.WriteLine(ilkharf);

        var konum = kursadı.IndexOf("C#");
        Console.WriteLine("konum" + konum);

        var aralık = kursadı.Substring(0, 2);
        Console.WriteLine(aralık);

        var içeriyor = kursadı.Contains("C#");
        Console.WriteLine(içeriyor);

        var güncellenmiş = kursadı.Replace("C#", "C++");
        Console.WriteLine(güncellenmiş);

      