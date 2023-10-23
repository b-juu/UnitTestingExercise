using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 3, 5, 11)]
        [InlineData(5, 3, 5, 13)]
        [InlineData(0, 0, 5, 5)]
        [InlineData(21, 3, 5, 29)]
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
        [InlineData(7, 3, 4)]
        [InlineData(11, 7, 4)]//Add test data <-------
        [InlineData(7, 4, 3)]
        [InlineData(9, 3, 6)]
        [InlineData(72, 36, 36)]
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
        [InlineData(5, 3, 15)]
        [InlineData(4, 7, 28)]
        [InlineData(12, 12, 144)]
        [InlineData(5, 7, 35)]
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
        [InlineData(15, 5, 3)]
        [InlineData(28, 4, 7)]
        [InlineData(9, 3, 3)]
        [InlineData(36, 12, 3)]
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
