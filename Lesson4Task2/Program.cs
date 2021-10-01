using System;
using System.Threading;

namespace Lesson4Task2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Calculator";

            Random rnd = new Random();
            bool isOk = true;

            while (isOk)
            {
                double operand1 = rnd.Next(0, 10);
                double operand2 = rnd.Next(0, 10);

                Console.WriteLine($"You have two operands: {operand1} and {operand2}");
                Console.WriteLine("Please choose some operation sign like '+', '-', '*' or '/'");

                string sign = Console.ReadLine().Trim();

                switch (sign)
                {
                    case "+":
                        {
                            Console.WriteLine("Im counting");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(".");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine();
                            Console.WriteLine($"Answer is: {operand1 + operand2}\n");
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("Im counting");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(".");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine();
                            Console.WriteLine($"Answer is: {operand1 - operand2}\n");
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine("Im counting");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(".");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine();
                            Console.WriteLine($"Answer is: {operand1 * operand2}\n");
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("Im counting");
                            for (int i = 0; i < 3; i++)
                            {

                                Console.Write(".");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine();
                            if (operand2 == 0)
                            {
                                Console.WriteLine("Can't divide by zero. Try again.\n");
                            }
                            else
                            {
                                Console.WriteLine($"Answer is: {operand1 / operand2}\n");
                            }
                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                    case "exit":
                        {
                            isOk = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"'{sign}' is not the sing what you had to choose. You can try again or quit the application (just write 'exit' in CMD).\n");
                            break;
                        }
                }
            }
        }
    }
}
