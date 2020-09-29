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
            if (lengthOfLine1.CompareTo(lengthOfLine2) == 0)
                Console.WriteLine("Line 1 & Line 2 are equal");
            else if (lengthOfLine1.CompareTo(lengthOfLine2) < 0)
                Console.WriteLine("Line 1 is smaller than Line 2");
            else
                Console.WriteLine("Line 1 is greater than Line 2");
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
