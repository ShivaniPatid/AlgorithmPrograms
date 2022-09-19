using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public static void SortArray()
        {
            string[] str = new string[] { "ball", "apple", "banana", "orange", "mango" };
            int i, j, flag;
            string val;

            for (i = 0; i < str.Length; i++)
            {
                val = str[i];
                flag = 0;

                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (str[j].CompareTo(val) > 0)
                    {
                        str[j + 1] = str[j];
                        j--;
                        str[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            Console.WriteLine("Sorted elements are : ");
            foreach (string element in str)
            {
                Console.WriteLine(element);
            }

        }
    }
}