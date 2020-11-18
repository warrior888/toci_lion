using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toci.lion.slower
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "beataza";

            string cont = "ata"; // palindrom

            if (Contains(name, cont))
            {
                Console.WriteLine("1 zawiera sie w 2");
            }

            Console.WriteLine(Reverse(name));

            Console.ReadLine();
        }

        static string Reverse(string candidate)
        {
            string result = string.Empty;

            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                result += candidate[i];
            }

            return result;
        }

        public static bool Contains(string candidate, string substring)
        {
            bool isInside = false;

            for (int i = 0; i < candidate.Length; i++)
            {
                for (int j = 0; j < substring.Length; j++)
                {
                    if (candidate[i] != substring[j])
                    {
                        isInside = false;
                        break;
                    }
                    if (candidate[i] == substring[j])
                    {
                        isInside = true;
                        i++;
                        if (i >= candidate.Length)
                        {
                            return false;
                        }
                    }
                    if (isInside && j == substring.Length - 1)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        static bool IsPalindrom(string candidate)
        {
            for (int i = 0, j = candidate.Length - 1; i < j ; i++, j--)
            {
                
            }

            return false;
        }
    }
}
