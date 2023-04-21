using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class IntegerConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter an integer: ");
            string integer = Console.ReadLine();

            if (IsAllDigits(integer))
            {
                int number = Convert.ToInt32(integer);
                string binary = Convert.ToString(number, 2);
                Console.WriteLine(binary);
            }
            else
            {
                Console.WriteLine("You entered non valid number!");
            }
        }

        private static bool IsAllDigits(string integer)
        {
            for (int i = 0; i < integer.Length; i++)
            {
                if (integer[i] < '0' || integer[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
