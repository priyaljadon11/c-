using System;

namespace MultiCast
{
    public delegate void Calculation(int a, int b);
    class Program
    {
        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result: {0}", result);

        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result: {0}", result);

        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result: {0}", result);

        }
        public static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addition);
            obj += Subtraction;
            obj += Multiplication;

            obj(30, 20);
        }

    }
}