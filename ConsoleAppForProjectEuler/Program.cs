using ProjectEuler._001__Multiples_of_3_or_5;
using ProjectEuler._002__Even_Fibonacci_numbers;

namespace ConsoleAppForProjectEuler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem001();
            Problem002();
        }

        //////////////////////////////////////////////////////////////////////
        private static void Problem001()
        {
            int a = new SummerOf3sAnd5s().FindSumBelowExcluding(1000);
            Console.WriteLine($"The answer to Problem 1 is: {a}");
            Console.WriteLine();
            // Answered correctly 2023.04.17
            // Answer = 233168
        }

        private static void Problem002()
        {
            int a = new SummerOfEvenValuedTerms().FindSumOfEvenTermsBelowIncluding(-4000000);
            Console.WriteLine($"The answer to Problem 2 is: {a}");
            Console.WriteLine();
            // Answered correctly 2023.04.18
            // Answer = 4613732
        }
    }
}