using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Add(num1, num2, num3);
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(7, 3, 4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 12)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            int actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 4, 3)] //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            int actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
