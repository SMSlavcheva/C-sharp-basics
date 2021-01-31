using System;

namespace Smallest_And_Largest_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Read series of integers

            string input = Console.ReadLine();
            int largestNum = int.MinValue;
            int smallestNum = int.MaxValue;

            while (input!="end")
            {

                int currentNumber = int.Parse(input);

                if (currentNumber>smallestNum)
                {
                    largestNum = currentNumber;
                
                }
                else
                {
                    smallestNum = currentNumber;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Smallest number is: {0}\nLargest number is: {1}  ", smallestNum,largestNum);
           

        }
    }
}
