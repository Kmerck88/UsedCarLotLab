using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    internal class Validator
    {

        public static bool GetContinue()
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n: ");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if(choice == "y")
                {
                    result = true;
                    break;
                }
                else if(choice == "n")
                {
                    result = false;
                    Console.Write("Goodbye.");
                    break;
                }
                else
                {
                    Console.WriteLine("That was an invalid entry. Try again.");
                }
            }
            return result;
        }

    

    }
}
