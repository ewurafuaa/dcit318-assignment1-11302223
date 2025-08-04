using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator {
    internal class Program {
        static void Main(string[] args){
            bool keepRunning = true;

            while (keepRunning) {
                Console.Write("Enter your grade (0-100): ");
                string input = Console.ReadLine();
                int numberGrade;

                if (int.TryParse(input, out numberGrade) && numberGrade >= 0 && numberGrade <= 100) {
                    string letter;

                    if (numberGrade >= 90)
                        letter = "A";
                    else if (numberGrade >= 80)
                        letter = "B";
                    else if (numberGrade >= 70)
                        letter = "C";
                    else if (numberGrade >= 60)
                        letter = "D";
                    else
                        letter = "F";

                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else {
                    Console.WriteLine("Invalid input. Please key in a number between 0 and 100.");
                }

                Console.Write("Want to key in another grade? (y/n): ");
                string again = Console.ReadLine().ToLower();
                if (!(again == "y" || again == "yes")) {
                    keepRunning = false;
                    Console.WriteLine("Thank you for using our Grade Calculator!");
                }
            }
        }
    }
}