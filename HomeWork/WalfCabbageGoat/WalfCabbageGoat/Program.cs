using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Description of the task: .......");

            string answer = "";
            bool guess = false;
            while (true)
            {
                guess = false;
                Console.Write("Enter value - ");
                string value = Console.ReadLine();

                if (value == "3" && answer == "")
                {
                    answer = "3";
                    guess = true;
                }
                if (value == "8" && answer == "3")
                {
                    answer += "8";
                    guess = true;
                }
                if (value == "2" && answer == "38")
                {
                    answer += "2";
                    guess = true;
                }
                if (value == "7" && answer == "382")
                {
                    answer += "7";
                    guess = true;
                }
                if (value == "1" && answer == "3827")
                {
                    answer += "1";
                    guess = true;
                }
                if (value == "8" && answer == "38271")
                {
                    answer += "8";
                    guess = true;
                }
                if (value == "3" && answer == "382718")
                {
                    break;
                }
                // second 
                if (value == "1" && answer == "38")
                {
                    answer += "1";
                    guess = true;
                }
                if (value == "7" && answer == "381")
                {
                    answer += "7";
                    guess = true;
                }
                if (value == "2" && answer == "3817")
                {
                    answer += "2";
                    guess = true;
                }
                if (value == "8" && answer == "38172")
                {
                    answer += "8";
                    guess = true;
                }
                if (value == "3" && answer == "381728")
                {
                    break;
                }
                if (guess)
                {
                    Console.WriteLine("Step is right. ");
                }
                else
                {
                    Console.WriteLine("Your step is wrong. Please try again");
                }

            }

            Console.WriteLine("You are winner!");
            Console.ReadLine();



        }
    }
}
