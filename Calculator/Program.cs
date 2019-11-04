using System;

namespace Calculator
{
    class MainClass
    {
        //property
        static Calculator calculator = new Calculator();
        static bool isOn = true;

        public static void Main(string[] args)
        {
            do
            {
                displayMenu();

                string userInput = Console.ReadLine();

                selectMenu(userInput);
            } while (isOn);
        }


        //gets input from user
        private static int inputNumber()
        {
        tryAgain:;
            Console.WriteLine("Input your number");

            string input = Console.ReadLine();
            
            int value;
            if (!int.TryParse(input, out value)) {
                Console.WriteLine("Not a number, try again!");
                goto tryAgain;
            }
            return value;
        }

        //makes a choice in menu
        private static void selectMenu(string userInput)
        {

            Console.Clear();

            switch (userInput)
            {
                case "1":
                    calculator.FirstNumber = inputNumber();
                    calculator.SecondNumber = inputNumber();
                    Console.WriteLine(calculator.FirstNumber + " + " + calculator.SecondNumber + " = " + calculator.SumNumbers());
                    break;
                case "2":
                    calculator.FirstNumber = inputNumber();
                    calculator.SecondNumber = inputNumber();
                    Console.WriteLine(calculator.FirstNumber + " x " + calculator.SecondNumber + " = " + calculator.MultiplyNumbers());
                    break;
                case "3":
                    calculator.FirstNumber = inputNumber();
                    calculator.SecondNumber = inputNumber();
                    Console.WriteLine("Sum in between = " + calculator.SumInBetween());
                    break;
                case "4":
                    calculator.NumberInMemory = inputNumber();
                    Console.WriteLine($"{calculator.NumberInMemory} successfully added to memory");
                    break;
                case "5":
                    calculator.NumberInMemory = 0;
                    Console.WriteLine("”Number in memory cleared");
                    break;
                case "6":
                    Console.WriteLine(calculator +"\n");
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    isOn = false;
                    break;
                default:
                    Console.WriteLine("Wrong input, try again!\n");
                    break;
            }
        }

        //show the menu in console
        private static void displayMenu()
        {
            string menu =
                "1.Add two numbers\n" +
                "2.Multiply two numbers\n" +
                "n3.Sum the numbers between two numbers.\n" +
                "4.Add number to memory\n" +
                "5.Clear memory\n" +
                "6.Print calculator contents.\n" +
                "7.Quit";
            Console.WriteLine(menu);
        }
    }
}
