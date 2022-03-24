using System;

namespace DateTimeFormate
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Console.WriteLine("{0:d}", dt);//short date
            //Console.WriteLine("{0:D}", dt);//long date
            //Console.WriteLine("{0:f}", dt);//full date/time(short time)

            //Console.WriteLine("{0:F}", dt);//full date/time(long time)

            Console.WriteLine("{0:g}", dt);//general date/time(short time)


            Console.WriteLine("{0:t}", dt);//time
            Console.WriteLine("{0:T}", dt);// LONG time

            Console.WriteLine("{0:yyyy}", dt);//year
            Console.WriteLine("{0:ddd}", dt);//short week name(thus)
            Console.WriteLine("{0:dddd}", dt);//long week name(thrusday)

            Console.WriteLine("{0:HH}", dt);//HOUR(00 TO 23)
            Console.WriteLine("{0:FF}", dt);//Two digit of second fraction)
            Console.WriteLine("{0:MM}", dt);//month as a number 01 to 12
            Console.WriteLine("{0:MMM}", dt);//month name(march)

            Console.WriteLine("{0:HH:mm:ss:tt}", dt);//time
            Console.WriteLine("{0:dd-MM-yyyy}", dt);//time
        }
    }
}
