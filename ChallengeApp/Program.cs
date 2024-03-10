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

    var statisticsInMemorry = employeeInMemorry.GetStatistics();
    Console.WriteLine($"Min :{statisticsInMemorry.Min}");
    Console.WriteLine($"Max :{statisticsInMemorry.Max}");
    Console.WriteLine($"Average :{statisticsInMemorry.Average:N2}");
    Console.WriteLine($"Average :{statisticsInMemorry.AverageLetter}");

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

    var statisticsInFile = employeeInFile.GetStatistics();
    Console.WriteLine($"Min :{statisticsInFile.Min}");
    Console.WriteLine($"Max :{statisticsInFile.Max}");
    Console.WriteLine($"Average :{statisticsInFile.Average:N2}");
    Console.WriteLine($"Average :{statisticsInFile.AverageLetter}");

}
