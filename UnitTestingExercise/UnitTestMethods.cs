using System;

namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference

        public int Add(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }

        // Create an Add method that passes 3 integers

        public int Subtract(int minuend, int subtrahend)
        {
            return (minuend - subtrahend);
        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }


        // Create a Multiply method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            return (num1 / num2);
        }



        public string GetGoodbye()
        {
            return "Goodbye";
        }
        // Create a Divide method that passes 2 integers

        public string GetName()
        {
            return "Name";
        }



        // Create 2 methods that will utilize the [Fact] tests you wrote

        
    }
}
