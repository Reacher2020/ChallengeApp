using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", 45);
float min, max, avg;

List<Employee> employees = new List<Employee>();

employee1.AddGrade(10.90F);
employee1.AddGrade(-7.90f);

var statistics = employee1.GetStatistics();
min=statistics.Min;
max=statistics.Max;
avg=statistics.Average;
avg=avg;

