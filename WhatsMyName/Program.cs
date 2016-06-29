using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            int UserNumber;

            Console.WriteLine("Whats your Name?");
            Name = Console.ReadLine();
            Console.WriteLine("Hello {0}", Name);

            Console.WriteLine("Please enter a number between 0-10");
            UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber <= 0 | UserNumber >=1 0)
            {
            Console.WriteLine("your number is invalid");
            }
        else
            {
            Console.WriteLine("Your number is {0}", FirstNumber);
            }
            Console.WriteLine("Your number is {0}", FirstNumber);
            Console.ReadLine();
        }
    }
}
