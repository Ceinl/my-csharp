using System;

class Program
{
    static void Main()
    {
        Console.Write("give a number: ");
        string userInput = Console.ReadLine();
        int num;

        try
        {
            num = Convert.ToInt32(userInput);
            Console.WriteLine("resutf of divide by zero: " + (num / 0));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: you cant divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: give a number please.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unknown error: " + ex.Message);
        }

        Console.ReadKey();
    }
}
