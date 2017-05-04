using System;

namespace HelloCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumbers(64, 32);
            Console.WriteLine(result);
            Console.WriteLine(AddNumbers(-1, 32));
            Console.ReadKey();
        }

        private static int AddNumbers(int numberOne, int numberTwo)
        {
            int CalculationResult;
            CalculationResult = numberOne + numberTwo;
            return CalculationResult;
        }
    }
}
