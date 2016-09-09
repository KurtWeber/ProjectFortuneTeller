using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string roygbiv;
            int numSiblings;

            Console.Write("Welcome to my fortune teller App.  With just a few details, I can tell you your furture." + "\n" + "\n");
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("\n" + firstName); //  testing variable

            Console.Write("\n" + "Please enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("\n" + lastName); // testing variable

            Console.Write("\n" + "Please enter your age in years: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + age);
            
            Console.ReadKey();
        }
    }
}
