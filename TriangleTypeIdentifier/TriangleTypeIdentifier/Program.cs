using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier {
    internal class Program{
        static void Main(string[] args) {
            bool keepRunning = true;

            while (keepRunning){
                Console.WriteLine("Enter the lengths of the three sides of the triangle:");

                Console.Write("Side 1: ");
                string input1 = Console.ReadLine();
                Console.Write("Side 2: ");
                string input2 = Console.ReadLine();
                Console.Write("Side 3: ");
                string input3 = Console.ReadLine();

                if (double.TryParse(input1, out double side1) &&
                    double.TryParse(input2, out double side2) &&
                    double.TryParse(input3, out double side3) &&
                    side1 > 0 && side2 > 0 && side3 > 0)
                {
                    // Check if it's a valid triangle
                    bool isValid = side1 + side2 > side3 &&
                                   side1 + side3 > side2 &&
                                   side2 + side3 > side1;

                    if (!isValid) {
                        Console.WriteLine("The sides do not form a valid triangle.");
                    }
                    else if (side1 == side2 && side2 == side3) {
                        Console.WriteLine("Triangle Type: Equilateral");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3) {
                        Console.WriteLine("Triangle Type: Isosceles");
                    }
                    else {
                        Console.WriteLine("Triangle Type: Scalene");
                    }
                }
                else {
                    Console.WriteLine("Invalid input. Please enter positive numbers only.");
                }

                Console.Write("Check another triangle? (y/n): ");
                string again = Console.ReadLine().ToLower();
                if (!(again == "y" || again == "yes")) {
                    keepRunning = false;
                    Console.WriteLine("Thank you for using the Triangle Type Identifier.");
                }
            }
        }
    }
}