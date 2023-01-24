using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementSumCountAverageCalculator
{
    internal class ElementSCAC
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5]; // You can change the element number from here.
            int evenSum = 0, oddSum = 0;
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Enter 5 elements of the array:"); // Dont forget to correct here (only if you change the element number)
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                    evenCount++;
                }
                else
                {
                    oddSum += arr[i];
                    oddCount++;
                }
            }

            Console.WriteLine("Even elements sum: " + evenSum);
            Console.WriteLine("Even elements count: " + evenCount);
            Console.WriteLine("Even elements average: " + (evenSum / evenCount));
            Console.WriteLine("Odd elements sum: " + oddSum);
            Console.WriteLine("Odd elements count: " + oddCount);
            Console.WriteLine("Odd elements average: " + (oddSum / oddCount));
        }
    }
}