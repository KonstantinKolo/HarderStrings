using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarderStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string first = input[0];
            string second = input[1];
            int firstCount = 0;
            int secondCount = 0;
            if (first.Length == second.Length)
            {
                for (int s1 = 0; s1 < first.Length - 1; s1++)
                {
                    if (firstCount != secondCount) 
                    {
                        break;
                    }
                    if (first[s1] == first[s1 + 1])
                    {
                        firstCount++;
                    }
                    else
                    {
                        firstCount = 0;
                    }
                    if (second[s1] == second[s1 + 1])
                    {
                        secondCount++;
                    }
                    else
                    {
                        secondCount = 0;
                    }
                }
                if (firstCount == secondCount) 
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
