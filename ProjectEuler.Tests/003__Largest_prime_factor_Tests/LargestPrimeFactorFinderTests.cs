using FluentAssertions;
using NUnit.Framework;
using ProjectEuler._003__Largest_prime_factor;

namespace ProjectEuler.Tests._003__Largest_prime_factor_Tests
{
    [TestFixture]
    public class LargestPrimeFactorFinderTests
    {
        // The class being tested.
        LargestPrimeFactorFinder _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new();
        }

        [Test]
        public void _00__ProjectEulerExampleTest()
        {
            // arrange
            int compositeNumber = 13195;
            int largestPrimeFactor = 29;

            // act
            int a = _underTest.FindLargestPrimeFactor(compositeNumber);

            // assert
            a.Should().Be(largestPrimeFactor);
        }

        [Test]
        public void _01__SelfExamples()
        {
            // sort of "end-to-end"
        }

        [Test]
        public void _02__AOORExceptions()
        {

        }

        [TestCase(   2,  2, ExpectedResult = 1)]
        [TestCase( 128,  2, ExpectedResult = 1)]
        [TestCase(  81,  3, ExpectedResult = 1)]
        [TestCase( 125,  5, ExpectedResult = 1)]
        [TestCase(  13, 13, ExpectedResult = 1)]
        [TestCase(2197, 13, ExpectedResult = 1)]
        public int _03__CheckFactorExtractorForPowersOfPrimes(int inputNumber, int factorToFactorOut)
        {
            // arrange
            // test cases are arranged above

            // act
            int a = _underTest.FactorExtractor(inputNumber, factorToFactorOut);

            // assert
            return a;


        }
    }
}
