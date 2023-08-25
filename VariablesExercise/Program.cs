namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string personName = "Alex";
            int personAge = 30; 
            char middleInitial = 'R';
            bool isMarried = true;
            double currentTemp = 60.5;
            decimal currentPrice = 4.99m;

            Console.WriteLine($"Hello, World! My name is {personName} , and I am {personAge} years old. ");
            Console.WriteLine($"My middle initial is {middleInitial} and if you were to ask me if I were married, I would have to say that it is {isMarried}.");
            Console.WriteLine($"The current temperature outside currently is {currentTemp} degrees and the price of my favorite hamburger is {currentPrice} US dollars.");



        }
    }
}
