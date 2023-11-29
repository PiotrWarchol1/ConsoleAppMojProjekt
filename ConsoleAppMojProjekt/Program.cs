using ConsoleAppMojProjekt;
using System.Reflection.Metadata;

Console.WriteLine("------------------------------------");
Console.WriteLine("PROGRAM OCENIAJĄCY TRENIG NA SIŁOWNI");
Console.WriteLine("------------------------------------");
Console.WriteLine("                        ");
Console.WriteLine("                        ");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Proszę wpisać odpowiedznią liczbę od 0 do 100");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("                        ");

var user = new UserInMemmory("Piotr", "Warchoł");
user.NumberAdded += UserNumberAdded;

void UserNumberAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowy numer");
}

while (true)
{
    Console.WriteLine("Proszę o wpisanie kolejnego numeru");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    try
    {
        user.AddNumber(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = user.GetStatistics();
Console.WriteLine($"Wartość średnia: {statistics.Average}");
Console.WriteLine($"Wartość minimalna: {statistics.Min}");
Console.WriteLine($"Wartość maxymalna: {statistics.Max}");
