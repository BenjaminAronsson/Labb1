using System;
namespace Calculator
{
    public class Calculator
    {
        //Properties
        public int FirstNumber { get; set; } = 0;
        public int SecondNumber { get; set; } = 0;
        public int NumberInMemory { get; set; } = 0;

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public override String ToString() 
        {
            return $"First number: {FirstNumber} \nSecond number: {SecondNumber} \nNumber in memory: {NumberInMemory}";
        }

        public int SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween()
        {
            if(FirstNumber > SecondNumber)
            {
                int temp = FirstNumber;
                FirstNumber = SecondNumber;
                SecondNumber = temp;
            }
            int number = 0;

            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                number += i;
            }
            return number;
        }
    }
}
