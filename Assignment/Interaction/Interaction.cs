using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public  class Interaction
    {
        static void Main(string[] args)
        {
            User user = new User("user", "password");
            bool success = false;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please, enter username: ");
                string enteredUser = Console.ReadLine();
                Console.Write("Please, enter password: ");
                string enteredPassword = Console.ReadLine();

                if (user.GetUser().Equals(enteredUser) && user.GetPassword().Equals(enteredPassword))
                {
                    success = true;
                    Console.WriteLine("Success!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
            if (!success)
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}
