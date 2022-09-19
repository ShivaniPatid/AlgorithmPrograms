using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public static void SortArray()
        {
            int[] array = new int[] { 20, 25, 15, 30, 10, 5 };
            int temp, i, j;
            for (i = 0; i < array.Length - 1; i++)
            {
                for(j=0 ; j < array.Length-1 ; j++)
                {
                    if  ( array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array elements are : ");
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }

        }
    }
}
