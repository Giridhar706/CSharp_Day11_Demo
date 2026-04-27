using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("TDD Calculator Demo\n");
            Console.WriteLine("Multiply: " + calc.Multiply(2, 6));
            Console.WriteLine("Add: " + calc.Add(5, 3));
            Console.WriteLine("Subtract: " + calc.Subtract(10, 4));
            Console.WriteLine("Divide: " + calc.Divide(8, 2));
        }
    }

    public class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            return a / b;
        }
    }
}
