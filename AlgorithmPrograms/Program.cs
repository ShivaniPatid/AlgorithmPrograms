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
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
