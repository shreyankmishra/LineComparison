using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    class LineCompare
    {
        private int x1, x2, y1, y2;
        public double CalculateLength()
        {
            Console.WriteLine("Enter values x1 and y1 for Line 1");
            this.x1 = Convert.ToInt32(Console.ReadLine());
            this.y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 1");
            this.x2 = Convert.ToInt32(Console.ReadLine());
            this.y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return length;
        }
        public void CompareLength(double len1, double len2)
        {
            int diffLength = len1.CompareTo(len2);
            if (diffLength == 0)
            {
                Console.WriteLine("Lines are equal in length");
            }
            else if (diffLength > 0)
            {
                Console.WriteLine("Line 1 is greater in length than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is smaller in length than Line 2");
            }
        }
    }
}
