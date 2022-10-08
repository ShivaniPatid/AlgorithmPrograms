using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option");
            Console.WriteLine("1. All permutations of a String");
            Console.WriteLine("2. Insertion sort of an array of a string");
            Console.WriteLine("3. Bubble sort of an array of a integer");
            Console.WriteLine("4. Anagram Detection");
            Console.WriteLine("5. Print Prime Numbers");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string str = "ABC";
                    int n = str.Length;
                    StringPermutations.Permute(str, 0, n - 1);
                    break;
                case 2:
                    InsertionSort.SortArray();
                    break;
                case 3:
                    BubbleSort.SortArray();
                    break;
                case 4:
                    AnagramProgram.AnagramDetection();
                    break;
                case 5:
                    PrimeNumber.PrintPrimeNumber();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
