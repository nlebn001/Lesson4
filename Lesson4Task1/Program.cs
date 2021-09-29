using System;


namespace Lesson4Task1
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Title = "Weather Dictionary";

            string rus;
            bool isOk = true;


            while (isOk)
            {
                Console.WriteLine("Введите слово на русском языке для перевода на английский.");
                rus = Console.ReadLine().ToLower().Trim();

                switch (rus)
                {
                    case "погода":
                        Console.WriteLine("Weather");
                        break;
                    case "солнечно":
                        Console.WriteLine("Sunny");
                        break;
                    case "ветренно":
                        Console.WriteLine("Windy");
                        break;
                    case "облачно":
                        Console.WriteLine("Cloudy");
                        break;
                    case "влажность":
                        Console.WriteLine("Humidity");
                        break;
                    case "жара":
                        Console.WriteLine("Heat");
                        break;
                    case "холод":
                        Console.WriteLine("Cold");
                        break;
                    case "градус":
                        Console.WriteLine("Degree");
                        break;
                    case "тепло":
                        Console.WriteLine("Warm");
                        break;
                    case "прогноз":
                        Console.WriteLine("Forecast");
                        break;
                    default:
                        Console.WriteLine("Слово не было найдено");
                        break;
                    case "выйти":
                        isOk = false;
                        break;
                }
            }

            Console.WriteLine("The program has exited with code 0");

        }
    }


}