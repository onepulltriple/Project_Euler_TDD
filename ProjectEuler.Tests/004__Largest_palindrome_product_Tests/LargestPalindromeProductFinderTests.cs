using FluentAssertions;
using NUnit.Framework;
using ProjectEuler._004__Largest_palindrome_product;

namespace ProjectEuler.Tests._004__Largest_palindrome_product_Tests
{
    [TestFixture]
    public class LargestPalindromeProductFinderTests
    {
        [SetUp]
        public void SetUp()
        {
            // not needed
        }

        [Test]
        public void _00__ProjectEulerExampleTest()
        {
            // arrange
            ulong a = 99;
            ulong b = 91;
            ulong palindromicNumber = 9009;

            // act
            ulong c = LargestPalindromeProductFinder.FindLargestPalindromeProduct(a, b);

            // assert
            c.Should().Be(palindromicNumber);
        }

        [TestCase(99, 99, ExpectedResult = (ulong)9009)]
        [TestCase(999, 999, ExpectedResult = (ulong)906609)]
        public ulong _01__SelfExamples(int a, int b)
        {
            // arrange
            // test cases are arranged above

            // act
            ulong c = LargestPalindromeProductFinder.FindLargestPalindromeProduct((ulong)a, (ulong)b);

            // assert
            return c;
        }

        [TestCase(9009, ExpectedResult = true)]
        [TestCase(90109, ExpectedResult = true)]
        [TestCase(99, ExpectedResult = true)]
        [TestCase(9001, ExpectedResult = false)]
        [TestCase(91, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(9001009, ExpectedResult = true)]
        public bool _02__CheckIsPalindromic(int inputNumber)
        {
            // arrange
            // test cases are arranged above

            // act
            bool a = LargestPalindromeProductFinder.IsPalindromic((ulong)inputNumber);

            // assert
            return a;
        }
    }
}
