using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Excerise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title for program
            Console.WriteLine("INFORMATION INPUT");
           
            //Prompts user to input first name
            Console.Write("What is your first name? ");
            //Declare a variable firstname to hold the first name from user
            string firstname = string.Empty;
            //Assign the user input string to firstname variable
            firstname = Console.ReadLine();

            //Prompts user to input last name
            Console.Write("What is your last name? ");
            //Declare a variable last to hold the last name from user
            string lastname = string.Empty;
            //Assign the user input string to lastname variable
            lastname = Console.ReadLine();

            //Prompts user to input age
            Console.Write("What is your age? ");
            //Declare a variable age to hold the age from user
            string age = string.Empty;
            //Assign the user input string to age variable
            age = Console.ReadLine();

            //Prompts user to input favorite number
            Console.Write("What is your favorite number? ");
            //Declare a variable favnum to hold the favorite number from user
            string favnum = string.Empty;
            //Assign the user input string to firstname variable
            favnum = Console.ReadLine();

            Console.WriteLine("Hello " + firstname + " " + lastname + "! You are " + age + " years old and your favorite number is " + favnum + ".");

            Console.Read();
        }
    }
}
