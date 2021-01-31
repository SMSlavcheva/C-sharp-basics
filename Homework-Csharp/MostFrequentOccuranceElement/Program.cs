using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_MostFrequentOccuranceElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which finds the most frequently occurring element in an array. 

            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
           
            
            // Fill in the array
            for (int i = 0; i < n; i++)
            {
                int argument = int.Parse(Console.ReadLine());
                arr[i] = argument;
                    
            }

            FindMostFrequentNum(arr);
            

          static void FindMostFrequentNum( int[] arr)
        {
                int count = 1;
                int frequent = 0;
                int highestCount = 0;
                int mostFrequent = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            frequent = arr[i];
                            if (count > highestCount)
                            {
                                highestCount = count;
                                mostFrequent = frequent;
                            }
                        }
                        else
                        {
                            count = 1;

                        }
                    }
                    count = 1;
                }
                if (mostFrequent == 0)
                {
                    Console.WriteLine("{0}", arr[0]);
                }
                else
                {
                    Console.WriteLine("Most frequent number is : {0} with {1} occurences", mostFrequent, highestCount);

                }

            }
        }
    }
}
