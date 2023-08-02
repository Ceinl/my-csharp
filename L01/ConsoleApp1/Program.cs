/*
     
 
 
*/

namespace ConsoleApp1
{
    internal class Program
    {

        static void sum(int first_number, int second_number) {Console.Write($"Answer: {first_number + second_number} \n");}

        static void dec(int first_number, int second_number) { Console.Write($"Answer:{first_number - second_number} \n"); }

        static void mult(int first_number, int second_number) { Console.Write($"Answer:{first_number * second_number} \n"); }

        static void div(int first_number, int second_number) { Console.Write($"Answer:{first_number / second_number} \n"); }

        static (int, int) GetNumbers()
        {
            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            return (firstNumber, secondNumber);
        }


        static void Main(string[] args)
        {

            (var firstNumber, var secondNumber) = GetNumbers();

            Console.WriteLine("Please chose action \n1 - Sum\n2-dec\n3-mult\n4-div");

            int switchNum = int.Parse(Console.ReadLine());

            switch (switchNum)
            {
                case 1: sum(firstNumber, secondNumber); break;
                case 2: dec(firstNumber, secondNumber); break;
                case 3: mult(firstNumber, secondNumber); break;
                case 4: div(firstNumber, secondNumber); break;

            }



        }
    }
}