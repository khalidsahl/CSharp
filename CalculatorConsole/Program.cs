using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main()
        {
            string line;

            Console.WriteLine(
                "Welcome! Press the following numbers to perform the calculation you wish. (press CTRL+Z to exit):)");
            Console.WriteLine("1. Division");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Subtraction");
            Console.WriteLine("4. Addition");

            do
            {
                var a = new Arthimetic();
                Console.Write("  ");
                line = Console.ReadLine();
                if (line != null)
                {
                    if (line.Equals("1"))
                    {
                        Console.WriteLine("You have selected division. Please insert two values (a, b) to be calculated.");

                        try
                        {
                            string[] array = Console.ReadLine().Split();                    
                            double[] input = Array.ConvertAll(array, s => double.Parse(s)); // converts string array to double.
                            Console.Write(a.Division(input[0], input[1]));
                        }
                        catch (Exception e)
                        {    
                            Console.WriteLine(e.Message);
                        }
                    }
                    else if (line.Equals("2"))
                    {
                        Console.WriteLine("You have selected multiplication. Please insert two values (a, b) to be calculated.");
                        try
                        {
                            string[] array = Console.ReadLine().Split();
                            double[] input = Array.ConvertAll(array, s => double.Parse(s)); // converts string array to double.
                            Console.Write(a.Multiplication(input[0], input[1]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    else if (line.Equals("3"))
                    {
                        Console.WriteLine("You have selected subtraction. Please insert two values (a, b) to be calculated.");
                        try
                        {
                            string[] array = Console.ReadLine().Split();
                            double[] input = Array.ConvertAll(array, s => double.Parse(s)); // converts string array to double.
                            Console.Write(a.Subtraction(input[0], input[1]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    else if (line.Equals("4"))
                    {
                        Console.WriteLine("You have selected addition. Please insert two values (a, b) to be calculated.");
                        try
                        {
                            string[] array = Console.ReadLine().Split();
                            double[] input = Array.ConvertAll(array, s => double.Parse(s)); // converts string array to double.
                            Console.Write(a.Addition(input[0], input[1]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            } while (line != null);
        }
    }
}
