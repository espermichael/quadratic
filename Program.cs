using System;

namespace quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            //opening statement
            Console.WriteLine("Solve the roots of a quadratic, Ax^2 + Bx + C = 0");
            //collect values of A, B, and C
            Console.WriteLine("Enter value of A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of C:");
            int c = Convert.ToInt32(Console.ReadLine());

            //A can't be zero.
            if (a != 0 ){
            
            // define the determinate. 
            int d = b*b-(4*a*c);

            //Test is determinate is non-negative
            if (d >= 0)
            {
                double rootOne = (-b + Math.Sqrt(d))/(2*a);
                double rootTwo = (-b - Math.Sqrt(d))/(2*a);
              Console.WriteLine("The determinate is non-negative with a value of: " + d);
              Console.WriteLine("The roots of the equation are: " + rootOne + " and " + rootTwo);
              
            }
            else
            {
            Console.WriteLine("The determinate is negative with a value of: " + d + " No real roots exist"); 
            }
            }

            else {
                Console.WriteLine("Coefficent A can't be 0. This is not a quadratic equation");
            }
        }
    }
}
