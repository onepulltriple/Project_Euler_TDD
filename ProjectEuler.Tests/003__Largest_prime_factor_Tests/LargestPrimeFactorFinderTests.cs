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
    }
}
