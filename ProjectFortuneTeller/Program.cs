﻿using System;
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
            string vehicle = "";  // Had to declare value for switch case
            string moneyBank;
            double think;
            int pause;

            //User input
            Console.Write("Welcome to my fortune teller App.  With just a few details, I can tell you your furture.\n\n");
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();


            Console.Write("\nPlease enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("\nPlease enter your age in years: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("\nPlease enter your birth month: ");
            birthMonth = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("\nPlease enter your favorite ROYGBIV color: \nType \"Help\" if you need the colors defined ");
                roygbiv = Console.ReadLine();
                if (roygbiv.ToLower() == "help")
                {
                    Console.WriteLine("\nHere is the ROYGBIV color palette: \n");
                    Console.WriteLine("R - Red");
                    Console.WriteLine("O - Orange");
                    Console.WriteLine("Y - Yellow");
                    Console.WriteLine("G - Green");
                    Console.WriteLine("B - Blue");
                    Console.WriteLine("I - Indigo");
                    Console.WriteLine("V - Violet");
                    //Console.Write("\n" + "Not part of the ROYGBIV color palette.  Please try again: ");
                    //roygbiv = Console.ReadLine();
                }
                if (roygbiv.ToLower() != "help")
                {
                    if (roygbiv.ToLower() != "red" && roygbiv.ToLower() != "orange" && roygbiv.ToLower() != "yellow" && roygbiv.ToLower() != "green" && roygbiv.ToLower() != "blue" && roygbiv.ToLower() != "indigo" && roygbiv.ToLower() != "violet")
                    {
                        Console.WriteLine("\nPlease try again.");
                    }
                }
            } while(roygbiv.ToLower() != "red" && roygbiv.ToLower() != "orange" && roygbiv.ToLower() != "yellow" && roygbiv.ToLower() != "green" && roygbiv.ToLower() != "blue" && roygbiv.ToLower() != "indigo" && roygbiv.ToLower() != "violet");

            Console.Write("\nPlease enter your number of sibling: ");
            numSiblings = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Age odd/even check
            if (age % 2 != 0)
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
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyBank = "250,000.00";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyBank = "1,000,000.00";
            }
            else
            {
                moneyBank = "0.00";
            }

            // Thinking
            Console.Write("Thinking: ");
            for (think = 0; think <= 50; think++)
            {
                {                    
                    Console.Write("*");
                }
                for (pause = 0; pause <= 100000000; pause++)
                {
                }
            }
            // Printout fortune
            Console.Write("\n\n{0} {1} will retire in {2} years with ${3} in the bank, \na vacation home in {4} and a {5}.", firstName, lastName, retYrs, moneyBank, vacHome, vehicle);
            Console.ReadKey();
        }
    }
}
