using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            List<int> answ = new List<int>();
            bool add = false;
            string above10;
            int sum;
            inputOne = new string(inputOne.ToCharArray().Reverse().ToArray());
            inputTwo = new string(inputTwo.ToCharArray().Reverse().ToArray());
            if (inputOne.Length >= inputTwo.Length)
            {
                for (int s1 = 0; s1 < inputOne.Length; s1++)
                {
                    if (s1 < inputTwo.Length)
                    {
                        sum = Convert.ToInt32(new string(inputOne[s1], 1)) + Convert.ToInt32(new string(inputTwo[s1], 1));
                        if (add == true)
                        {
                            sum++;
                        }
                        if (sum >= 10)
                        {
                            above10 = $"{sum}";
                            answ.Add(Convert.ToInt32(new string(above10[1], 1)));
                            add = true;
                        }
                        else
                        {
                            answ.Add(sum);
                            add = false;
                        }
                    }
                    //Add the nums larger than second length
                    else
                    {
                        sum = Convert.ToInt32(new string(inputOne[s1], 1));
                        if (add == true)
                        {
                            sum++;
                        }
                        if (sum >= 10)
                        {
                            above10 = $"{sum}";
                            answ.Add(Convert.ToInt32(new string(above10[1], 1)));
                            add = true;
                        }
                        else
                        {
                            answ.Add(sum);
                            add = false;
                        }
                    }
                }
                if (add == true)
                {
                    answ.Add(1);
                }
            }
            else
            {
                for (int s1 = 0; s1 < inputTwo.Length; s1++)
                {
                    if (s1 < inputOne.Length)
                    {
                        sum = Convert.ToInt32(new string(inputOne[s1], 1)) + Convert.ToInt32(new string(inputTwo[s1], 1));
                        if (add == true)
                        {
                            sum++;
                        }
                        if (sum >= 10)
                        {
                            above10 = $"{sum}";
                            answ.Add(Convert.ToInt32(new string(above10[1], 1)));
                            add = true;
                        }
                        else
                        {
                            answ.Add(sum);
                            add = false;
                        }
                    }
                    //Add the nums larger than first length
                    else
                    {
                        sum = Convert.ToInt32(new string(inputTwo[s1], 1));
                        if (add == true)
                        {
                            sum++;
                        }
                        if (sum >= 10)
                        {
                            above10 = $"{sum}";
                            answ.Add(Convert.ToInt32(new string(above10[1], 1)));
                            add = true;
                        }
                        else
                        {
                            answ.Add(sum);
                            add = false;
                        }
                    }
                }
                if (add == true)
                {
                    answ.Add(1);
                }
            }
            answ.Reverse();
            Console.WriteLine(string.Join("", answ));
        }
    }
}
