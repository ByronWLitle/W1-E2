using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            
            Console.WriteLine("Hello "+ firstname + " "+ lastname + ". You are "+ age + " years old.");

            Console.Read();
        }
    }
}
