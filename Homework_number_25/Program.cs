using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[11] { 2, 11, 3, 6, 10, 8, 7, 5, 9, 1, 4 };
            bool isSorted = false;
            int frontNumber;
            int step = 1;
            int tempNumder;
            int lastIndexInArray = numbers.Length - 1;
            int countNumbersSorted;

            Console.WriteLine("Массив до сортировки: ");

            foreach (int number in numbers)
            {
                Console.Write($"{number},");
            }

            while (isSorted == false)
            {
                countNumbersSorted = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    frontNumber = i + step;

                    if (frontNumber <= lastIndexInArray)
                    {
                        if (numbers[i] > numbers[frontNumber])
                        {
                            tempNumder = numbers[i];
                            numbers[i] = numbers[frontNumber];
                            numbers[frontNumber] = tempNumder;
                        }
                        else
                        {
                            countNumbersSorted++;
                        }
                    }
                }

                if (countNumbersSorted == lastIndexInArray)
                {
                    isSorted = true;
                }
            }

            Console.WriteLine("\nМассив после сортировки: ");

            foreach (int number in numbers)
            {
                Console.Write($"{number},");
            }
        }
    }
}
