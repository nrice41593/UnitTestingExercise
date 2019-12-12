using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 3, 1, 7)]
        [InlineData(9, 6, 1, 16)]
        [InlineData(3, 3, 5, 11)]
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
        [InlineData(8, 4, 4)]
        [InlineData(10, 4, 6)]
        [InlineData(12, 10, 2)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(3, 3, 9)]
        [InlineData(7, 2, 14)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Multipy(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(32, 2, 16)]
        [InlineData(81, 9, 9)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        //[Fact]
        //public void YourMethodName()
        //{
            //Arrange

            //Act

            //Assert

        //}

       // [Fact]
        //public void YourMethodName2()
        //{
            //Arrange

            //Act

            //Assert
       // }
    }
}
