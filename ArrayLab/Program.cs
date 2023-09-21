using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter;
            string keepGoing = "Y";

            while (keepGoing == "Y" || keepGoing == "y")
            {
                Console.WriteLine("How many scores would you like to register?");
                var inputCounter = Console.ReadLine();

                if (int.TryParse(inputCounter, out counter))
                    Console.WriteLine($"You want to process: {counter} grades.");
                else
                    Console.WriteLine("This is not a number!");

                double[] testScores = new double[counter];
               
                for (int i = 0;  i < testScores.Length; i++)
                {
                    Console.WriteLine("Enter the next test score.");
                    var checkScores = Console.ReadLine();
                    if (double.TryParse(checkScores, out testScores[i]))
                        Console.WriteLine($"You entered:"   + testScores[i]);
                    else
                        Console.WriteLine("This is not a fractional number");
                }
                
                Console.WriteLine("Do you want to reset? Y/N");
                keepGoing = Console.ReadLine();

                Console.ReadLine();


            }

   

        }
        
    }
}