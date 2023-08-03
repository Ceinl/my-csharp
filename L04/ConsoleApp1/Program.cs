namespace ConsoleApp1
{
    internal class Program
    {

        static void displayElement<Thing>(Thing[] todisp)
        {
            foreach(Thing item in todisp)
            {
                Console.WriteLine(item + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3, 4, 5};

            double[] doublearray = { 1.0, 2.0, 3.0 };

            string[] stringarray = { "1", "2", "3" };

            displayElement<int>(intarray);
            displayElement<double>(doublearray);
            displayElement<string>(stringarray);

        }
    }
}