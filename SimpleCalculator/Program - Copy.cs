using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class ProgramOld
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            double x = 0, y = 0;
            string userResponse;
            string operation;
            string operationSymbol = "";
            double answer = 0;
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

            while (true)
            {
                //
                // display header
                //
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("       The Simple Calculator");
                Console.WriteLine();



                validResponse = false;
                while (!validResponse)
                {
                    //
                    // get numbers from user
                    //
                    Console.Write("Enter the first number:");
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out x))
                    {
                        Console.WriteLine("You must enter a number. (2.4, 9, etc.)");
                    }
                    else
                    {
                        validResponse = true;
                    }
                }


                Console.WriteLine();

                Console.Write("Enter the second number:");
                userResponse = Console.ReadLine();
                y = double.Parse(userResponse);
                Console.WriteLine();

                //
                // get operation from user
                //
                Console.Write("Enter the operation (add/subtract/multiply/divide):");
                operation = Console.ReadLine();
                Console.WriteLine();


                //
                // perform operation
                //
                if (operation == "add")
                {
                    answer = x + y;
                    operationSymbol = "+";
                }
                else if (operation == "subtract")
                {
                    answer = x - y;
                    operationSymbol = "-";
                }
                else if (operation == "multiply")
                {
                    answer = x * y;
                    operationSymbol = "*";
                }
                else if (operation == "divide")
                {
                    answer = x / y;
                    operationSymbol = "/";
                }


                //
                // display the answer
                //
                Console.WriteLine("{0} {1} {2} = {3}", x, operationSymbol, y, answer);
                Console.WriteLine($"{x} {operationSymbol} {y} = {answer}");
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
