using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            Console.WriteLine("Enter coordinates of Line1");
            double lengthOfLine1 = LengthOfLine();
            Console.WriteLine("Length of line 1: " + lengthOfLine1);
            Console.WriteLine("Enter coordinates of Line2");
            double lengthOfLine2 = LengthOfLine();
            Console.WriteLine("Length of line 2: " + lengthOfLine2);
            if (lengthOfLine1 == lengthOfLine2)
                Console.WriteLine("Both the lines are equal");
            else
                Console.WriteLine("Both the lines are unequal");
        }
        static double LengthOfLine()
        {
            Console.WriteLine("Enter the X & Y coordinates of starting point of the line");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X & Y coordinates of ending point of the line");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
    }
}
