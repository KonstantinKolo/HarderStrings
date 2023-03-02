using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string curent;
            string helper;
            float nums = 0;
            float endResult = 0;
            float firstPos;
            float secondPos;
            for (int s1 = 0; s1 < input.Count; s1++)
            {
                curent = input[s1];
                helper = curent;
                helper = helper.Substring(1);
                helper = helper.Remove(helper.Length - 1, 1);
                nums = float.Parse(helper);
                if (curent[0] < 91)
                {
                    firstPos = curent[0] - 64;
                    nums = nums / firstPos;
                }
                else
                {
                    firstPos = curent[0] - 96;
                    nums = nums * firstPos;
                }

                if (curent[curent.Length - 1] < 91)
                {
                    secondPos = curent[curent.Length - 1] - 64;
                    nums = nums - secondPos;
                }
                else
                {
                    secondPos = curent[curent.Length - 1] - 96;
                    nums = nums + secondPos;
                }
                endResult += nums;
            }
            Console.WriteLine($"{endResult:F2}");
        }
    }
}
