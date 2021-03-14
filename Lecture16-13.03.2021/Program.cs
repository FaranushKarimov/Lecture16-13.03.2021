using System;
using System.Linq;
namespace Lecture16_13._03._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // 1 
                int number = int.Parse(Console.ReadLine());

                var numberStr = number.ToString();

                var numberArray = numberStr.Select((item) => item).ToArray().Reverse();

                foreach (var e in numberArray)
                {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
            {
                // 2 
                int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };

                var arrayPosCount = array.Where((item) => item > 0).Count();
                var arrayNegativeSum = array.Where((item) => item < 0).Sum();

                int[] Result = new int[] { arrayPosCount, arrayNegativeSum };
                foreach (var item in Result)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            {
                // 3
                string[] array = new string[] { "Telescopes", "Glasses", "Eyes", "Monocles" };

                // Ordering by ascending
                var resultSorted = array.Select((item) => item).OrderBy((item) => item.Length).ToArray();

                foreach (var item in resultSorted)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
            }
            {
                // 4 
                String[] array = new string[] { "0.2", "0.2", "0.55", "0.2", "0.2" };

                var result = array.GroupBy((item1) => item1).Where((item2) => item2.Count() == 1).FirstOrDefault();

                Console.WriteLine(result.Key);
            }

        }
    }
    }

