using System;

namespace Anonymous
{
    class Program { 

        delegate void Anonyms(int a);
        static void Main(string[] args)
        {
            Anonyms obj = delegate (int a)
            {
                a += 10;
                Console.WriteLine(a);
            };
            obj(5);
        }
    

    }
}
