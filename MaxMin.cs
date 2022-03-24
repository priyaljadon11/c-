using System;
public class MinMax
{
    static void min(int[] arr)
    {
        int min = arr[0];
         for(int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Minimum element is: " + min);
    }
     static void max(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Maximum Element is: " + max);
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 101, 20, 40, 50, 6 };
        int[] arr2 = { 2, 44, 33, 56, 24, 78 };
        min(arr1);
        max(arr2);
    }
}
