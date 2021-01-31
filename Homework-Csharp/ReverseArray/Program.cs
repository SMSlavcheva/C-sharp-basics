using System;

namespace ReverseArray
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //Write down a program that revers the items in an array 
            //I assume that items in the array are of type int, but other assumption are also possible
            
            var n = int.Parse(Console.ReadLine());
           
            var arr = new int[n];
           
            // Read array from Console
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            var firstElement = arr[0];
            var lastElement = arr[n - 1];


            for (int i = 0; i < arr.Length/2; i++)
            {
                int temp = 0;
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(",",arr));
        }
    }
}
