using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DevBuild.Factorials
{
    class Program
    {
        private static ulong factorialTotal = 1; 

        static void Main(string[] args)
        {
            int factorialBase = 0;
            string userResponse = "";

            Console.Write("***********************************************************\n" +
                          "*             Dev.Build(2.0) - Factorials                 *\n" +
                          "***********************************************************\n\n");

            while (true)
            {
                Console.Write("Please enter a number between 1 and 20, and I'll print out the factorial: \n" +
                    "(21! evaluates to 50+ quintillion, higher than 64 bits can store...) ");

                //Let's make sure that the user entered a number, and that it's not a number whose factorial we can't store just yet
                if (int.TryParse(Console.ReadLine(), out factorialBase) && factorialBase < 21)
                {
                    factorialTotal = GetFactorial(factorialBase);
                    Console.WriteLine("Factorial of {0} ({0}!) is {1:N0}", factorialBase, factorialTotal + "\n\n");
                }

                while (userResponse != "y" & userResponse != "n")
                {
                    Console.Write("Do you want to try another number?");
                    userResponse = Console.ReadLine();
                }
                switch (userResponse)
                {
                    case "y": Console.WriteLine("\n"); userResponse = ""; continue; //break;
                    case "n": return;
                }
            }
            //Thread.Sleep(5000);
        }

        /// <summary>
        /// This method will calculate the factorial of an entered number
        /// </summary>
        /// <param name="highestFactor">The highest factorial the method should calculate</param>
        /// <returns></returns>
        public static ulong GetFactorial(int highestFactor)
        {
            if (highestFactor == 0)
            {
                return 1;
            }
            else return (ulong)highestFactor * GetFactorial(highestFactor - 1);


        }
    }
}
