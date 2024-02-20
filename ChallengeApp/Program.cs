using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", 45);
Employee employee2 = new Employee("Roman", "Adamski", 32);
Employee employee3 = new Employee ("Anna", "Powierża", 37);
Employee employee4 = new Employee ("Marta", "Sosnowska", 29);
List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};
int maxResult = -1;
List<Employee> employeeWithMaxResult = new List<Employee>();

employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(4);
employee1.AddScore(3);
employee1.AddScore(8);

employee2.AddScore(10);
employee2.AddScore(1);
employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(2);

employee3.AddScore(8);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(9);
employee3.AddScore(9);

employee4.AddScore(3);
employee4.AddScore(1);
employee4.AddScore(4);
employee4.AddScore(9);
employee4.AddScore(1);

foreach(var employee in employees)
{
    if(employee.Result == maxResult)
    {
        employeeWithMaxResult.Add(employee);
    }
    else if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult.Clear();
        employeeWithMaxResult.Add(employee);
    }
}
Console.WriteLine("Pracowni-k/cy z max liczba puntow:");
foreach (var employee in employeeWithMaxResult)
{
    Console.Write(employee.Name + " " + employee.Surname + " " + employee.Age + " lat" + " " + employee.Result + " puntow.\n");
}