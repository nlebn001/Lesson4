using System;

namespace Lesson4Task3
{
    /*
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой
        промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. Если да, то укажите, в какой именно промежуток. Если
        пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то
        выводится соответствующее сообщение.
     */


    class Program
    {
        static void Main(string[] args)
        {

            string str;
            int number;
            bool isOk = true;

            while (isOk)
            {
                Console.WriteLine("Type some integer (not float or double or decimal) from 0 till 100, please.");
                str = Console.ReadLine().Trim();

                bool isNum = int.TryParse(str, out number);

                if (isNum)
                {
                    if (number >= 0 && number <= 14)
                    {
                        Console.WriteLine("Your number is in range of [0-14].");
                    }
                    else if (number >= 15 && number <= 35)
                    {
                        Console.WriteLine("Your number is in range of [15-35].");
                    }
                    else if (number >= 36 && number <= 50)
                    {
                        Console.WriteLine("Your number is in range of [36-50].");
                    }
                    else if (number >= 50 && number <= 100)
                    {
                        Console.WriteLine("Your number is in range of [50-100].");
                    }
                    else
                    {
                        Console.WriteLine("Your number is out of the range.");
                    }
                }
                else
                {
                    switch (str)
                    {
                        case "exit":
                            {
                                isOk = false;
                                break;
                            }

                        case "clear":
                            {
                                Console.Clear();
                                break;
                            }

                        default:
                            {
                                Console.WriteLine($"{str} is not a number. Try again.");
                                break;
                            }
                    }

                }
            }
        }
    }
}
