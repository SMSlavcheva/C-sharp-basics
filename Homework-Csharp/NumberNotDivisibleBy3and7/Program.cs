using System;

namespace NumberNotDivisibleBy3and7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Write a program that prints on the console the numbers from 1 to N,
            //which are not divisible by 3 and 7 simultaneously. The number N should be 
            //read from the standard input.​

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i%21!=0)
                {
                    Console.WriteLine(i);
                }
            }            
        }
    }
}
