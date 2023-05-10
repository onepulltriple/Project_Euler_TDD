using System.Linq;

namespace ProjectEuler._004__Largest_palindrome_product
{
    public class LargestPalindromeProductFinder
    {
        public static void FindLargestPalindromeProduct()
        {

        }

        public static bool IsPalindromic(int numberToCheck)
        {
            string asString = numberToCheck.ToString();
            return asString.SequenceEqual(asString.Reverse());
        }
    }
}
