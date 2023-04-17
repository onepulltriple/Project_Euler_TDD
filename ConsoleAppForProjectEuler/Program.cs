using ProjectEuler._001__Multiples_of_3_or_5;

namespace ConsoleAppForProjectEuler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem001();
        }

        //////////////////////////////////////////////////////////////////////
        private static void Problem001()
        {
            // Problem 001
            int a = new SummerOf3sAnd5s().FindSumBelowExcluding(1000);
            Console.WriteLine($"The answer to Problem 1 is: {a}");
            Console.WriteLine();
            // Answered correctly 2023.04.17
            // Answer = 233168
        }
    }
}