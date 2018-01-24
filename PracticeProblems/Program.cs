using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Problem One
            //Console.WriteLine("Please enter your name:");
            //string name = Console.ReadLine();
            //int cupsNeeded = 7;
            //int cupsUsed = 2;
            //Console.WriteLine(name + " must add " + (cupsNeeded-cupsUsed) + " more cups of sugar to the muffin mix.");

            ////Problem Two
            //Console.WriteLine("Please enter your name:");
            //name = Console.ReadLine();
            //int partialBill = 13;
            //int numberOfDiners = 4;
            //Console.WriteLine("{0} and friends racked up a total dinner bill of ${1}.", name, (partialBill * numberOfDiners));

            ////Problem Three
            //Console.WriteLine("Please enter your name:");
            //name = Console.ReadLine();
            //int bankAccount = 40;
            //int daiperPrice = 8;
            //Console.WriteLine("{0} can buy {1} packages of daipers because they have ${2} remaining in their bank account.", name, (bankAccount / daiperPrice), bankAccount);

            ////Problem Four
            //Console.WriteLine("Please enter your name:");
            //name = Console.ReadLine();
            //int trevonFriday = 29;
            //int trevonMonday = 41;
            //Console.WriteLine("{0} made {1} over the weekend by cleaning the attic.", name, (trevonMonday - trevonFriday));

            ////Problem Five
            //Console.WriteLine("Please enter the first place name:");
            //string nameOne = Console.ReadLine();
            //Console.WriteLine("Please enter the second place name:");
            //string nameTwo = Console.ReadLine();
            //int totalMiles = 47;
            //int ExtraMiles = 30;
            //Console.WriteLine("{0} ran {2} more miles than {1}.", nameOne, nameTwo, (totalMiles - ExtraMiles));

            ////Problem Six
            //Console.WriteLine("Please enter your name:");
            //name = Console.ReadLine();
            //bankAccount = 12;
            //int cost = 3;
            //Console.WriteLine("{0} can buy {1} boxes.", name, (bankAccount / cost));

            ////Problem Seven
            //Console.WriteLine("Please enter your name:");
            //name = Console.ReadLine();
            //double saladCost = 5.12;
            //double remainingCash = 27.10;
            //Console.WriteLine("{0} had ${1} in their wallet before they bought a salad.", name, (saladCost +  remainingCash));


            ////Loop Homework

            //Console.WriteLine("Welcome to the Countries Game!  Hit any key to begin");
            //Console.ReadLine();
            //var start = DateTime.Now;

            //string[] countries = new string[25];

            //for(int i = 0; i < countries.Length; i++)
            //{
            //    Console.WriteLine("Please enter a country name: ");
            //    countries[i] = Console.ReadLine();
            //}

            //var end = DateTime.Now;
            //var duration = end - start;

            //Console.WriteLine("It took you {0} to name 25 countries!", duration);

            //Console.WriteLine("Here's every other country you named: ");

            //for(int i =0; i < countries.Length; i++)
            //{
            //    int divisionTest = i % 2;
            //    if(divisionTest ==0)
            //    {
            //        Console.WriteLine(countries[i]);
            //    }

            //} 

            //Loop practice in class: get user input of 10 numbers, sum them and find average.
            Console.WriteLine("Please enter the length of your array: ");
            int lengthArray = int.Parse(Console.ReadLine());

            int[] myNumbers = new int[lengthArray];
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                myNumbers[i] = int.Parse(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 0; i < myNumbers.Length; i++)
            {
                sum = sum + myNumbers[i];
            }
            Console.WriteLine("Sum of all the numbers: " + sum);
            double average = sum / myNumbers.Length;
            Console.WriteLine("The average of the numbers is " + average);


        }
    }
}
