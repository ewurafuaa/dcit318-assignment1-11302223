using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPriceCalculator {
    internal class Program {
        static void Main(string[] args) {
            bool keepRunning = true;

            while (keepRunning) {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                int age;

                if (int.TryParse(input, out age) && age >= 0){
                    int price;

                    if (age <= 12 || age >= 65){
                        price = 7;
                    }
                    else {
                        price = 10;
                    }

                    Console.WriteLine("Ticket price: GHC" + price);
                }
                else{
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }

                Console.Write("Check another customer? (y/n): ");
                string again = Console.ReadLine().ToLower();
                if (!(again == "y" || again == "yes"))
                {
                    keepRunning = false;
                    Console.WriteLine("Thank you for using our Ticket Price Calculator.");
                }
            }
        }
    }
}