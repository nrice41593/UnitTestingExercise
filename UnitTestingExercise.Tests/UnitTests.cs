using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 3, 3, 9)]
        [InlineData(0, 1, 2, 3)]
        [InlineData(5, 7, 3, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange

            UnitTestMethods challenger = new UnitTestMethods();

            //Act

            int actual = challenger.Add(num1, num2, num3);

            //Assert

            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(18, 9, 9)]
        [InlineData(16, 8, 8)]
        [InlineData(15, 5, 10)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            //Act
            int actual = challenger.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(5, 3, 15)]
        [InlineData(7, 2, 14)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(12, 12, 1)]
        [InlineData(20, 5, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SayWoof()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.SayWoof();
            //Assert
            Assert.Equal("Woof", actual);

        }

        [Fact]
        public void MerryChristmas()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.MerryChristmas();
            //Assert
            Assert.Equal("Merry Christmas!", actual);
        }
    }
}
