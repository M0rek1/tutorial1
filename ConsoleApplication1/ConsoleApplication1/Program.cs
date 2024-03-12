using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("fff");
            Console.WriteLine("fff2");
            Console.WriteLine("fff3");
            int[] numbers = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers);
            Console.WriteLine("Average: " + average);



        }

        public static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return (double)sum / array.Length;
        }
    }
}

