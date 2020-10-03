using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation.");
            LineCompare line = new LineCompare();
            double[] lineLength = new double[2];
            for (int numLines = 0; numLines < 2; numLines++)
            {
                lineLength[numLines] = line.CalculateLength();
            }
            line.CompareLength(lineLength[0], lineLength[1]);
        }
    }
}
