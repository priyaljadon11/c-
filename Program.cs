using System;

namespace MultipleDelegate
{
    public delegate void Calculate(int a, int b);
    public delegate void ShowDele();
    public delegate void SqureCube(int a);

    class Program
    {
        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result: {0}", result);
        }
        public static void Show()
        {
            Console.WriteLine("Print show method.");
        }
        public static void Squre(int a)
        {
            int result = a * a;
            Console.WriteLine("Squre result: {0}", result);
        }
        public static void Cube(int a)
        {
            int result = a * a * a;
            Console.WriteLine("Cube result: {0}", result);
        }
        public static void Main(string[] args)
        {
            Calculate obj = new Calculate(Program.Addition);
            obj.Invoke(20, 30);
            ShowDele obj1 = new ShowDele(Show);
            obj1.Invoke();
            SqureCube obj3 = new SqureCube(Squre);
            obj3.Invoke(3);
            obj3 = Cube;
            obj3(2);
        }
    }
}