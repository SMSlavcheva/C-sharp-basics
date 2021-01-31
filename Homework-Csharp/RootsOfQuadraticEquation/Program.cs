using System;

namespace RootsOfQuadraticEquation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //(a*x^2 + b*x + c = 0)

            Console.WriteLine("Enter arguments:");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            CalculateRoots(a, b, c);
        }

        private static void CalculateRoots(double a, double b, double c)
        {
                double x1 = 0;
                double x2 = 0;
                double d = 0;

                d = (b * b) - (4 * a * c);
                if (d == 0)
                {
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    Console.WriteLine("Roots Are Equal x1=x1={0}", x1);
                }
                else if (d > 0)
                {
                    x1 = -b + Math.Sqrt(d) / (2.0 * a);
                    x2 = -b - Math.Sqrt(d) / (2.0 * a);
                    Console.WriteLine("First Root = {0}", x1);
                    Console.WriteLine("Second Root = {0}", x2);
                }
                else
                    Console.WriteLine("There is no real roots. Roots = {0}", c/0);
            }
        }
    }
    

