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
        public void _00__ProjectEurlerExampleTest()
        {
            // arrange
            int palindromicNumber = 9009;

            // act
            int a = LargestPalindromeProductFinder.FindLargestPalindromeProduct();

            // assert
            a.Should().Be(palindromicNumber);
        }
    }
}
