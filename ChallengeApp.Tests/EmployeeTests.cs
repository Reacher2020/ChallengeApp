namespace ChallengeApp.Tests
{
    public class EmployeeTestTest
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorectMax()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42, 'm');
            employee.AddGrade(10.98f);
            employee.AddGrade(4.02f);

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(10.98f, statistics.Max);
        }

        [Test]
        public void WhenGetStatistics_ShouldReturnCorectMin()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42, 'm');
            employee.AddGrade(10.98f);
            employee.AddGrade(4.02f);

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(4.02f, statistics.Min);
        }

        [Test]
        public void WhenGetStatistics_ShouldReturnCorectAverange()
        {
 
            var employee = new Employee("Adam", "Kowalski", 42, 'm');
            employee.AddGrade(10.98f);
            employee.AddGrade(4.02f);

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(7.5f, statistics.Average);
        }

        [Test]
        public void WhenAddLetterAsGrade_ShuldReturnCorectAverangIcPoints()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42, 'm');
            employee.AddGrade('A');
            employee.AddGrade('E');

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(60, statistics.Average);
        }

        [Test]
        public void WhenAddPointsAsGrade_ShuldReturnCorectAverangIcLetters()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42, 'm');
            employee.AddGrade(100);
            employee.AddGrade(20);

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void WhenAddLetterAsGrade_ShuldReturnCorectMaxIcPoints()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42, 'm');
            employee.AddGrade('A');
            employee.AddGrade('E');

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenAddLetterAsGrade_ShuldReturnCorectMinIcPoints()
        {
            //Arrange
            var employee = new Employee("Adam", "Kowalski", 42, 'm');
            employee.AddGrade('A');
            employee.AddGrade('E');

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(20, statistics.Min);
        }

    }
}