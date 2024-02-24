namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void Test_Int()
        {
            //Arrange
            int number_int_1 = 12;
            int number_int_2 = 12;

            //Assert
            Assert.AreEqual(number_int_1, number_int_2);
        }

        [Test]
        public void Test_Float()
        {
            //Arrange
            float number_float_1 = 12.79f;
            float number_float_2 = 12.79f;

            //Assert
            Assert.AreEqual(number_float_1, number_float_2);
        }


        [Test]
        public void Test_Double()
        {
            //Arrange
            double number_double_1 = 12.45;
            double number_double_2 = 12.45;

            //Assert
            Assert.AreEqual(number_double_1, number_double_2);
        }

        [Test]
        public void Test_String()
        {
            //Arrange
            string str_1 = "Piotrek";
            string str_2 = "Piotrek";

            //Assert
            Assert.AreEqual(str_1, str_2);
        }


        [Test]
        public void Test_Reference()
        {
            //Arrange
            var employee_1 = new Employee("Anna", "Powierża", 37);
            var employee_2 = new Employee("Anna", "Powierża", 37);

            //Assert
            Assert.AreNotEqual(employee_1, employee_2);
            Assert.AreEqual(employee_1.Name, employee_2.Name);
            Assert.AreEqual(employee_1.Surname, employee_2.Surname);
            Assert.AreEqual(employee_1.Age, employee_2.Age);
        }
    }

}
