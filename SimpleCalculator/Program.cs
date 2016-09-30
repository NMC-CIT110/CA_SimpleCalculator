using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            double number1 = 0, number2 = 0;
            double answer = 0;

            string userResponse;
            string operation;
            string operationSymbol = "";

            bool quitting = false;
            bool validResponse;

            //
            // display opening screen
            //
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Simple Calculator");
            Console.WriteLine("Author Bonzo");
            Console.WriteLine();

            //
            // pause for user
            //
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //
            // application loop
            //
            while (!quitting)
            {
                //
                // get and validate the first number from the user
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // display header
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("       The Simple Calculator");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("Enter the first number:");
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out number1))
                    {
                        Console.WriteLine("You must enter a number. (2.4, 9, etc.)");
                    }
                    else
                    {
                        validResponse = true;
                    }
                }


                //
                // get and validate the second number from the user
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // display header
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("       The Simple Calculator");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("Enter the second number:");
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out number2))
                    {
                        Console.WriteLine("You must enter a number. (2.4, 9, etc.)");
                    }
                    else
                    {
                        validResponse = true;
                    }
                }

                //
                // get and validate the operation from the user
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // display header
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("       The Simple Calculator");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("Enter the operation:");
                    operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "add":
                            answer = number1 + number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;
                        case "subtract":
                            answer = number1 - number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;
                        case "multiply":
                            answer = number1 * number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;
                        case "divide":
                            answer = number1 / number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;

                        default:
                            Console.WriteLine("You must enter a valid operation.");
                            Console.Write("Enter the operation (add/subtract/multiply/divide):");
                            operation = Console.ReadLine();
                            break;
                    }
                }

                //
                // display the answer
                //
                Console.WriteLine("{0} {1} {2} = {3}", number1, operationSymbol, number2, answer);
                Console.WriteLine($"{number1} {operationSymbol} {number2} = {answer}");
                Console.WriteLine();

                //
                // pause for user
                //
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
