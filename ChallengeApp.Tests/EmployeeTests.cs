namespace ChallengeApp.Tests
{
    public class EmployeeTestTest
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorectMax()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42);
            employee.AddGrade(10.98f);
            employee.AddGrade(4.02f);

            //Act
            var statistics = new Statistics();
            statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(10.98f, statistics.Max);
        }

        [Test]
        public void WhenGetStatistics_ShouldReturnCorectMin()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42);
            employee.AddGrade(10.98f);
            employee.AddGrade(4.02f);

            //Act
            var statistics = new Statistics();
            statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(4.02f, statistics.Min);
        }

        [Test]
        public void WhenGetStatistics_ShouldReturnCorectAverange()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42);
            employee.AddGrade(10.98f);
            employee.AddGrade(4.02f);

            //Act
            var statistics = new Statistics();
            statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(7.5f, statistics.Average);
        }
    }
}