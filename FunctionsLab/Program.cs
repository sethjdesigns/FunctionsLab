using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Level Manager Are You?");
            var managerLevel = Console.ReadLine();

            CheckLevel(managerLevel);

            Console.ReadLine();

        }

        private static void CheckLevel(string managerLevel)
        {


            if (managerLevel == "First")
            {
                Console.WriteLine("What is the price of the item?");
                var priceInput = Console.ReadLine();
                int itemPrice = Convert.ToInt32(priceInput);
                
                if (itemPrice < 250)
                {
                    Console.WriteLine("What is the description of the item?");
                    var itemDesc = Console.ReadLine(); 
                    invalidTerm(itemDesc);
                }
                else 
                {
                    Console.WriteLine("Please Escalate to Second Level Manager");
                }
            }

            else if (managerLevel == "Second")
            {
                Console.WriteLine("What is the price of the item?");
                var priceInput = Console.ReadLine();
                int itemPrice = Convert.ToInt32(priceInput);

                if (itemPrice < 500)
                {
                    Console.WriteLine("What is the description of the item?");
                    var itemDesc = Console.ReadLine();
                    invalidTerm(itemDesc);
                }
                else
                {
                    Console.WriteLine("Please Escalate to Director");
                }

                
            }

            else if (managerLevel == "Director")
            {
                Console.WriteLine("What is the price of the item?");
                var priceInput = Console.ReadLine();
                int itemPrice = Convert.ToInt32(priceInput);

                if ((itemPrice > 1000) && itemPrice < 5000) 
                {
                    Console.WriteLine("Are you buying hardware?");
                    var hardwareAnswer = Console.ReadLine();

                    if (hardwareAnswer == "yes")
                    {
                        Console.WriteLine("Approved");
                    }
                    else 
                    {
                        Console.WriteLine("Sorry you can only approve expenses above $1000 on hardware purchases");
                    }
                }

                else if (itemPrice < 1000)
                {
                    Console.WriteLine("What is the description of the item?");
                    var itemDesc = Console.ReadLine();
                    invalidTerm(itemDesc);
                }

                else
                {
                    Console.WriteLine("Please Escalate to CEO");
                }
            }

            else if (managerLevel == "CEO")
            {
                Console.WriteLine("You are the CEO You can Approve Anything You Want!");
            }
        }

        private static void invalidTerm(string itemDesc)
        {
            if (itemDesc.Contains("entertainment") || itemDesc.Contains("towncar") || itemDesc.Contains("towncars") || itemDesc.Contains("hardware"))
            {
                Console.WriteLine("Rejected");
            } 
            else
            {
                Console.WriteLine("Approved");
            }
        }

    }
}
