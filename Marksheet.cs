using System;

namespace Marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your RollNo.");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter your Class:");
            string standard = Console.ReadLine();
            Console.WriteLine("Enter Math Marks");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your English marks");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry Marks");
            int chy = int.Parse(Console.ReadLine());

            int obt = m + e + chy;
            int per = obt * 100 / 300;
            Console.WriteLine("---------Marksheet--------");
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your Roll no is: {0}", roll);
            Console.WriteLine("Your class is: {0}", standard);
            Console.WriteLine("Your obtain marks are: {0}", obt);
            Console.WriteLine("Your percentage is {0}", per);

            if(per >= 80)
            {
                Console.WriteLine("Grade: A-1");
            }
            else if(per >= 7)
            {
                Console.WriteLine("Grade: A");
            }
            else if(per >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if(per >= 6)
            {
                Console.WriteLine("Grade: c");
            }
            else
            {
                Console.WriteLine("Grade: F(Fail)");
            }


        }
    }
}
