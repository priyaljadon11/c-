using System;



 public delegate void Message(string Message);
class Program
{
    public static void Main(string[] args)
    {
        Message obj = new Message(Program.Hello);
        obj("priyal");
    }
    public static void Hello(string strMessage)
    {
        Console.WriteLine("Print Message: {0}", strMessage);
    }
}