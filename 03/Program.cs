using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            int intTwo = Convert.ToInt32(new string(inputTwo[0], 1));
            List<int> answ = new List<int>();
            bool add = false;
            string above10 = "0";
            int mult;
            inputOne = new string(inputOne.ToCharArray().Reverse().ToArray());
            for (int s1 = 0; s1 < inputOne.Length; s1++)
            {
                mult = Convert.ToInt32(new string(inputOne[s1], 1)) * intTwo;
                if (add == true)
                {
                    mult += Convert.ToInt32(new string(above10[0], 1));
                }
                if (mult >= 10)
                {
                    above10 = $"{mult}";
                    answ.Add(Convert.ToInt32(new string(above10[1], 1)));
                    add = true;
                }
                else
                {
                    answ.Add(mult);
                    add = false;
                }
            }
            if (add == true)
            {
                answ.Add(Convert.ToInt32(new string(above10[0], 1)));
            }
            answ.Reverse();
            Console.WriteLine(string.Join("", answ));
        }
    }
}
