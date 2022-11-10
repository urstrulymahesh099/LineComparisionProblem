using LineComparisionProblem;
using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparision problem statement ");
            CalculateLength calculate1 = new CalculateLength(1, 2, 3, 4);
            double length1 = calculate1.Calculate();
            CalculateLength calculate2 = new CalculateLength(1, 2, 4, 4);
            double length2 = calculate2.Calculate();
            if (length1.Equals(length2))//length1==length2
                Console.WriteLine("Both Lines are Equals");
            else
                Console.WriteLine("Both Lines are Not Equals");
        }
    }
}