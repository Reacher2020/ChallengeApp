using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", 45);
float min, max, avg;

List<Employee> employees = new List<Employee>();

employee1.AddGrade(10.98F);
employee1.AddGrade(4.02f);

var statistics = employee1.GetStatistics();
Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
Console.WriteLine($"Minimalna ocena: {statistics.Min}");
Console.WriteLine($"Srednia ocena: {statistics.Average}");

