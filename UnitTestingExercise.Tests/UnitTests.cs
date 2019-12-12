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
        [InlineData(20, 4, 16)]
        [InlineData(5, 4, 1)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(actual, expected);
        }

        //[Theory]
        //[InlineData]
        //public void Multiply(int num1, int num2, int expected)
        //{
            //Arrange

            //Act

            //Assert

        //}

        //[Theory]
       //[InlineData()
        //public void Divide(int num1, int num2, int expected)
        //{
            //Arrange

            //Act

            //Assert

        //}

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
