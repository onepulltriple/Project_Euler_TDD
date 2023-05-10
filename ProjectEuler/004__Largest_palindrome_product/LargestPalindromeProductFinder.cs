namespace ProjectEuler._004__Largest_palindrome_product
{
    public class LargestPalindromeProductFinder
    {
        public static ulong LargestPalindromeProduct()
        {
            Console.WriteLine("Please enter two numbers, each of which is a maximum of ten digits long.");
            Console.WriteLine("First number: ");
            ulong a = ReadInULong();
            Console.WriteLine("Second number: ");
            ulong b = ReadInULong();

            Console.Write($"The largest palindromic product of two positive integers equal to or less than {a} and {b} is: ");
            ulong c = FindLargestPalindromeProduct(a, b);
            Console.WriteLine($"{c}");

            return c;
        }

        public static ulong ReadInULong()
        {
            ulong result;
            bool validULong = false;

            do
            {
                string userInput = Console.ReadLine();
                validULong = ulong.TryParse(userInput, out result);
            } while (validULong == false);

            return result;
        }

        public static ulong FindLargestPalindromeProduct(ulong a, ulong b)
        {
            List<ulong> ListOfPalindromicNumbers = new();

            for (ulong i = a; i > 0; i--)
            {
                for (ulong j = b; j > 0; j--)
                {
                    if (IsPalindromic(i * j) && 
                        !ListOfPalindromicNumbers.Contains(i * j))
                    {
                        ListOfPalindromicNumbers.Add(i * j);
                    }
                }
            }

            return ListOfPalindromicNumbers.Max();
        }

        public static bool IsPalindromic(ulong numberToCheck)
        {
            string asString = numberToCheck.ToString();
            return asString.SequenceEqual(asString.Reverse());
        }
    }
}
