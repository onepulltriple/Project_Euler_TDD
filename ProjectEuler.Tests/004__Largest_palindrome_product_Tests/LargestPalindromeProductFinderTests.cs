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
            int palindromicNumber = 9009;

            // act
            //int a = LargestPalindromeProductFinder.FindLargestPalindromeProduct(palindromicNumber);

            // assert
            //a.Should().Be(palindromicNumber);
        }

        [Test]
        public void _01__SelfExamples()
        {
            // arrange


            // act


            // assert

        }

        [TestCase(9009, ExpectedResult = true)]
        [TestCase(90109, ExpectedResult = true)]
        [TestCase(99, ExpectedResult = true)]
        [TestCase(9001, ExpectedResult = false)]
        [TestCase(91, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(9001009, ExpectedResult = true)]
        public bool _03__CheckIsPalindromic(int inputNumber)
        {
            // arrange
            // test cases are arranged above

            // act
            bool a = LargestPalindromeProductFinder.IsPalindromic(inputNumber);

            // assert
            return a;
        }
    }
}
