using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 3, 3, 9)]

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
        [InlineData(5, 4, 1)]
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
        [InlineData(4, 4, 16)]
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
        [InlineData(10, 5, 2)]
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
        public void GetGoodbye()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.GetGoodbye();
            //Assert
            Assert.Equal(actual, "Goodbye");

        }

        [Fact]
        public void GetName()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
        //Act
        string actual = challenger.GetName();
            //Assert
            Assert.Equal(actual, "Name");
        }
    }
}
