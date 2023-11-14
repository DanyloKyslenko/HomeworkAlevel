using Recursion;
using BinarySearch;
using QuickSort;
namespace Homeworkk3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactorialAndFibonachi calculator = new FactorialAndFibonachi();
            int factorialResult = calculator.Factorial(4);
            Console.WriteLine($"Factorial 4 = \"{factorialResult}\"");
            int fibonachiResult = calculator.Fibonachi(4);
            Console.WriteLine($"Fibonachi 4 = \"{fibonachiResult}\"");
            Binary_Search binarysearch = new Binary_Search();
            int[] Array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchedValue = 5;

            int result = binarysearch.BinarySearch(Array, searchedValue, 0, Array.Length - 1);

            if (result != -1)
            {
                Console.WriteLine($"Значение {searchedValue} найдено в массиве по индексу {result}");
            }
            else
            {
                Console.WriteLine($"Значение {searchedValue} не найдено в массиве");
            }
            Console.Write("N = ");
            var len = Convert.ToInt32(Console.ReadLine());
            var a = new int[len];
            for (var i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sortedArray = Quick_Sort.QuickSort(a);

            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", sortedArray));

            Console.ReadLine();

        }
    }
}