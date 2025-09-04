//Exception 
//SystemşFormalException
//System.DivideByZeroException
//System.nullReferenceException
using System.Linq;

void parola_control(string password)
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



Console.Write("Parolanız:");
string? parola = Console.ReadLine();
try
{
    parola_control(parola);
    Console.WriteLine("Parolanız onaylandı.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
     