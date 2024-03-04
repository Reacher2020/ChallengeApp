using ChallengeApp;
{ 

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();

var employeeInMemorry = new EmployeeInMemorry("Pawel", "Sawicki", 45, 'm');
var employeeInFile = new EmployeeInFile("Adam", "Kamizelich", 40, 'm');
    employeeInMemorry.GradeAdded += EmployeeGradeAdded;
    employeeInFile.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender,  EventArgs args)
    {
        Console.WriteLine("Ocena została dodana.");
    }

    while (true)
    {
        Console.WriteLine("Podaj kolejna ocenę pracownika :");
        var imput = Console.ReadLine();
        if (imput == "q")
        {
            break;
        }
        try
        {
            employeeInMemorry.AddGrade(imput);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exeption catched : {ex.Message}");
        }

    }

    var statistics = employeeInMemorry.GetStatistics();
    Console.WriteLine($"Min :{statistics.Min}");
    Console.WriteLine($"Max :{statistics.Max}");
    Console.WriteLine($"Average :{statistics.Average:N2}");
    Console.WriteLine($"Average :{statistics.AverageLetter}");

    while (true)
    {
        Console.WriteLine("Podaj kolejna ocenę Kierownika :");
        var imput = Console.ReadLine();
        if (imput == "q")
        {
            break;
        }
        try
        {
            employeeInFile.AddGrade(imput);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exeption catched : {ex.Message}");
        }

    }

    statistics = employeeInFile.GetStatistics();
    Console.WriteLine($"Min :{statistics.Min}");
    Console.WriteLine($"Max :{statistics.Max}");
    Console.WriteLine($"Average :{statistics.Average:N2}");
    Console.WriteLine($"Average :{statistics.AverageLetter}");

}
