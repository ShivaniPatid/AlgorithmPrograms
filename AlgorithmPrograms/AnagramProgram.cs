using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramProgram
    {
        public static void AnagramDetection()
        {
            string str1 = "heart";
            string str2 = "earth";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            string value1 = new string(ch1);
            string value2 = new string(ch2);

            Console.WriteLine(value1+" "+value2);

            if (value1 == value2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
