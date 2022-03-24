using System;
class Program
{
    //public static void Main()
    //{
    //    int i = 0;
    //    SimpleMethod(ref i);//we don't use ref keyword to print 0 value,use ref keyword print 101 value
    //    Console.WriteLine(i);

    //}
    //public static void SimpleMethod(ref int j)
    //{
    //    j = 101;
    //}
    public static void Main()
    {
        int Total = 0;
        int product = 0;
        Calculate(10, 20, out Total, out product);

        Console.WriteLine("Sum = {0} && Product = {1}", Total,product);
    }
    public static void Calculate(int FN, int SN, out int sum, out int product){
        sum = FN + SN;
        product = FN * SN;
   }
}