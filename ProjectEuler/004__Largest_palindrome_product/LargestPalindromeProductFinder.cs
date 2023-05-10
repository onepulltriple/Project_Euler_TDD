using System.Linq;

namespace ProjectEuler._004__Largest_palindrome_product
{
    public class LargestPalindromeProductFinder
    {
        public static void LargestPalindromeProduct()
        {
            Console.WriteLine($"The largest palindromic product of two 3-digit numbers is: {FindLargestPalindromeProduct()}");
        }

        public static int FindLargestPalindromeProduct()
        {
            int a = 999;
            int b = 999;
            List<int> ListOfPalindromicNumbers = new();

            for (int i = a; i > 0; i--)
            {
                for (int j = b; j > 0; j--)
                {
                    if (IsPalindromic(i * j))
                    {
                        ListOfPalindromicNumbers.Add(i * j);
                    }
                }
            }

            return ListOfPalindromicNumbers.Max();
        }

        public static bool IsPalindromic(int numberToCheck)
        {
            string asString = numberToCheck.ToString();
            return asString.SequenceEqual(asString.Reverse());
        }
    }
}
