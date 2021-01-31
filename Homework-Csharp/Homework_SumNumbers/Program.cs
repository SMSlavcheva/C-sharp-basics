using System;

namespace Homework_SumNumbers
{
    public class Program
    {
       public static void Main(string[] args)
        {
            // Write a program that reads five integer numbers and prints their sum.
            //If an invalid number is entered the program should prompt the user to enter another number. 

            var result=0;
            var sum = 0;
            var count = 0;

            while(count<5)
            {
                    var number = (Console.ReadLine());

                    bool isNumeric = int.TryParse(number, out result);

                    if (isNumeric == true)
                    {
                        sum += result;
                        count++;
                    }

                    else
                    {
                        Console.WriteLine("Enter valid Number");
                    }
                          
            }
            Console.WriteLine("Sum is = {0}",sum);
            
        }
    }
}
