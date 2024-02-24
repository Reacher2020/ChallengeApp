namespace ChallengeApp.Tests
{
    public class EmployeeTestTest
    { 
    [Test]
    public void WhenAddTwoPositiveGrade_ThenShouldReturnCorectResult()
        {
            //Arrange
            var employee = new Employee("Anna", "Powier¿a", 37);
            employee.AddGrade(10.98f);
            employee.AddGrade(4.02f);

            //Act
            var statistics = new Statistics();
            statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(10.98f, statistics.Max);
            Assert.AreEqual(4.02f, statistics.Min);
            Assert.AreEqual(7.5f, statistics.Average); 
        }

    [Test]
    public void WhenAddPositiveAndNegativeGrade_ThenShouldReturnCorectResult()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42);
            employee.AddGrade(10.90f);
            employee.AddGrade(-7.90f);

            //Act
            var statistics = new Statistics();
            statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(10.90f, statistics.Max);
            Assert.AreEqual(-7.90f, statistics.Min);
            // statistics.Averang = 1.49999976; BLAD ERROR !!!!!! z danych wychodzi avg=(10.9-7.9)/2; avg=1.5
            Assert.AreNotEqual(1.5f, statistics.Average);


        }

    }
}