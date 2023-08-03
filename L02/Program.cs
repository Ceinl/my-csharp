namespace L02
{

    class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Animal(string name, string description) 
        {
            this.Name = name;
            this.Description = description;

        }
        public void printName() { Console.WriteLine(Name); }
        public void printDescription() { Console.WriteLine(Description); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("Bluse","White cat");
            Animal dog = new Animal("jaz", "Dachshund");

            dog.printName();

            cat.printDescription();
          

            
        }
    }
}