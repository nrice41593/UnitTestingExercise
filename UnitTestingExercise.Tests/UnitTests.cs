using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(4, 5, 6, 15)]
        [InlineData(15, 25, 35, 75)]
        [InlineData(123, 234, 345, 702)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();
            //Act
            int actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(100, 23, 77)]
        [InlineData(546, 231, 315)]
        [InlineData(-1, 43, -44)]
        [InlineData(32, -68, 100)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();
            //Act
            int actual = test.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(2, 6, 12)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();
            //Act
            int actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();
            //Act
            int actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
