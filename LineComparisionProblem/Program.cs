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
            CalculateLength calculate2 = new CalculateLength(1, 3, 3, 5);
            double length2 = calculate2.Calculate();
            if (length1.Equals(length2))//length1==length2
                Console.WriteLine("Both Lines are Equals");
            else
                Console.WriteLine("Both Lines are Not Equals");
            if (length1.CompareTo(length2) == 0)
                Console.WriteLine("line 1 and line 2 both are equal");
            if (length1.CompareTo(length2) > 0)
                Console.WriteLine("line 1 is greator than line 2");
            else
                Console.WriteLine("line 2 is greater than line 1");
        }
    }
}