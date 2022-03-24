using System;

namespace CallByReference
{
    class Program
    {
        public void cal1(ref int val)
        {
            val = val * val;
            Console.WriteLine("inside the call by reference " + val);
        }
        static void Main(string[] args)
        {
            int val = 25;
            Program obj = new Program();
            Console.WriteLine("Before calling by reference " + val);
            obj.cal1(ref val);
            Console.WriteLine("After callin by reference " + val);

        }
    }
}
