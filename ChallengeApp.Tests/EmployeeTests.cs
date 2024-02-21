namespace ChallengeApp.Tests
{
    public class Test
    { 
    [Test]
    public void WhenAddTwoPositiveScore_ThenShouldReturnCorectResult()
    {
        //Arrange
        var employee = new Employee("Anna", "Powier¿a", 37);
        employee.AddScore(10);
        employee.AddScore(4);

        //Act
        var score = employee.Result;

        //Assert
        Assert.AreEqual(14, score);
    }

    [Test]
    public void WhenAddPositiveAndNegativeScore_ThenShouldReturnCorectResult()
    {
        //Arrange
        var employee = new Employee("Adam", "Kowalski", 4);
        employee.AddScore(10);
        employee.AddScore(-7);

        //Act
        var score = employee.Result;

        //Assert
        Assert.AreEqual(3, score);
    }

}
}