using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();

var employee = new Employee("Pawel", "Sawicki", 45);

while(true)
{
    Console.WriteLine("Podaj kolejna ocenę pracownika :");
    var imput = Console.ReadLine();
    if(imput == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(imput);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exeption catched : {ex.Message}");
    }
}


var statistics = employee.GetStatistics();
Console.WriteLine($"Min :{statistics.Min}");
Console.WriteLine($"Max :{statistics.Max}");
Console.WriteLine($"Average :{statistics.Average:N2}");
Console.WriteLine($"Average ::{statistics.AverageLetter}");