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
            //Initialize input variables
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string roygbiv;
            int numSiblings;
         
            //Initialize misc variables
            int retYrs;
            string vacHome;
            string vehicle = "";
            string moneyBank;

            //User input
            Console.Write("Welcome to my fortune teller App.  With just a few details, I can tell you your furture." + "\n" + "\n");
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("\n" + "Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("\n" + "Please enter your age in years: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("\n" + "Please enter your birth month: ");
            birthMonth = int.Parse(Console.ReadLine());

            Console.Write("\n" + "Please enter your favorite ROYGBIV color: ");
            roygbiv = Console.ReadLine();

            Console.Write("\n" + "Please enter your number of sibling: ");
            numSiblings = int.Parse(Console.ReadLine());

            // Age odd/even check
            if (age / 2 != 0)
            {
                retYrs = 35; //Odd age
            }
            else
            {
                retYrs = 20; //Even age
            }
          
            // Set vacation home
            if (numSiblings == 0)
            {
                vacHome = "Hawaii";
            }
            else if (numSiblings == 1)
            {
                vacHome = "Florida";
            }
            else if (numSiblings == 2)
            {
                vacHome = "San Diego";
            }
            else if (numSiblings == 3)
            {
                vacHome = "Martha's Vineyard";
            }
            else if (numSiblings > 3)
            {
                vacHome = "Paris";
            }
            else
            {
                vacHome = "parent's basement";
            }

            // Set vehicle type
            switch (roygbiv = roygbiv.ToLower())
            {
                case "red":
                    vehicle = "row boat";
                    break;
                case "orange":
                    vehicle = "ocean liner";
                    break;
                case "yellow":
                    vehicle = "yacht";
                    break;
                case "green":
                    vehicle = "golf cart";
                    break;
                case "blue":
                    vehicle = "Buick";
                    break;
                case "indigo":
                    vehicle = "Infinity Q70";
                    break;
                case "violet":
                    vehicle = "van";
                    break;
            }
            // Set Money in the bank
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneyBank = "500,000.00";
            }
            else if (birthMonth >= 5 && birthMonth <=8)
            {
                moneyBank = "250,000.00";
            }        
            else if (birthMonth >= 9 && birthMonth <=12)
            {
                moneyBank = "1,000,000.00";
            }
            else
            {
                moneyBank = "0.00";
            }

            // Printout fortune
            Console.Write("\n" + "{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and a {5}.",firstName,lastName,retYrs,moneyBank,vacHome,vehicle);
         
            Console.ReadKey();
        }
    }
}
