using System;

namespace FindPrimeNumbersWithSieveOfAristothene
{
    public class Program
    {
        //Write a program that prints on the console the prime numbers in the from 1 to N 
        //int numbers sequence The number N should be read from the standard input.​
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          
            var result = new bool[n];
                      
            result = FindPrimes(n);
            PrintPrimes(result);           
            
        }

        private static void PrintPrimes(bool[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == true)
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static bool[] FindPrimes(int n)
        {
            
            var isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++) isPrime[i] = true;

            
            for (int i = 2; i <= n; i++)
            {
                
                if (isPrime[i])
                {
                  
                    for (int j = i * 2; j <= n; j += i)
                        isPrime[j] = false;
                }
            }
            return isPrime;
        }
    }
}
