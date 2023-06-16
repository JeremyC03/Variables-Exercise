namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName;
            myName = "Jeremy";

            int myAge;
            myAge = 28;

            char myInitial;
            myInitial = 'J';

            bool statement;
            statement = true;

            double number;
            number = 3;

            decimal year;
            year = 2023;

            Console.WriteLine($"Hello, my name is {myName}, and I am {myAge}.");
            Console.WriteLine($"My initial is {myInitial} and I like the number {number}.");
            Console.WriteLine($"This statement is {statement}.");
            Console.WriteLine($"The year is {year}.");

        }
    }
}
