using System;
using System.Linq;

namespace Lab07AssignArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = PrintPrimeNumbers();

            PrintArray("Prime numbers are", array);
        }

        static int ReadNumber(string label, int defaultValue)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            if (int.TryParse(value, out int result))
            {
                return result;
            }

            return defaultValue;
        }
       
        static void PrintArray(string label, int[] array)
        {
            Console.WriteLine();
            string elementList = string.Join(", ", array);
            Console.WriteLine($"{label}: {elementList}");
        }

        static int[] PrintPrimeNumbers()
        {
            int maxOfArray = ReadNumber("Print prime numbers until: ", 0);
            int[] array = new int[maxOfArray];
            int k = 0;

            bool isPrime = true;

            for (int i = 2; i <= maxOfArray; i++)
            {
                isPrime = true;

                for (int j = 2; j <= maxOfArray; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    array[k] = i;
                    k++;
                }
            }

            Array.Resize(ref array, k);

            return array;
        }
    }
}