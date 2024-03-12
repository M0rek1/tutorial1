using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("f");
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
        public static int FindMaxValue(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("Array is null or empty.", nameof(values));
            }

            int maxValue = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > maxValue)
                {
                    maxValue = values[i];
                }
            }
            return maxValue;
        }
        
    }
}

