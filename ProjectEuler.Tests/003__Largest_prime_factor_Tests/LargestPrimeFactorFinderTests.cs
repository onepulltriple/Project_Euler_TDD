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
            ulong numberInQuestion = 13195;
            ulong largestPrimeFactor = 29;

            // act
            ulong a = _underTest.FindLargestPrimeFactor(numberInQuestion);

            // assert
            a.Should().Be(largestPrimeFactor);
        }

        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 3)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(7, ExpectedResult = 7)]
        [TestCase(125, ExpectedResult = 5)]
        [TestCase(137, ExpectedResult = 137)]
        [TestCase(2281, ExpectedResult = 2281)]
        [TestCase(215656441, ExpectedResult = 29)]
        [TestCase(479010, ExpectedResult = 2281)]
        [TestCase(14804790, ExpectedResult = 29)]
        public int _01__SelfExamples(int inputNumber)
        {
            // arrange
            // test cases are arranged above
            ulong inputNumberUL = (ulong)inputNumber;

            // act
            ulong a = _underTest.FindLargestPrimeFactor(inputNumberUL);

            // assert
            return (int)a;
        }

        [TestCase(1)]
        [TestCase(0)]
        public void _02__AOORExceptions(int inputNumber)
        {
            // arrange
            // test cases are arranged above
            ulong inputNumberUL = (ulong)inputNumber;

            // act
            Action action = () => _underTest.FindLargestPrimeFactor(inputNumberUL);

            // assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [TestCase(5, 2, ExpectedResult = 5)]
        [TestCase(37, 3, ExpectedResult = 37)]
        [TestCase(137, 3, ExpectedResult = 137)]
        [TestCase(2281, 3, ExpectedResult = 2281)]
        public int _03__CheckFactorExtractorForPrimes(int inputNumber, int factorToFactorOut)
        {
            // arrange
            // test cases are arranged above
            ulong inputNumberUL = (ulong)inputNumber;
            ulong factorToFactorOutUL = (ulong)factorToFactorOut;

            // act
            ulong a = _underTest.ExtractFactor(inputNumberUL, factorToFactorOutUL);

            // assert
            return (int)a;
        }

        [TestCase(2, 2, ExpectedResult = 1)]
        [TestCase(128, 2, ExpectedResult = 1)]
        [TestCase(81, 3, ExpectedResult = 1)]
        [TestCase(125, 5, ExpectedResult = 1)]
        [TestCase(13, 13, ExpectedResult = 1)]
        [TestCase(2197, 13, ExpectedResult = 1)]
        public int _04__CheckFactorExtractorForPowersOfPrimes(int inputNumber, int factorToFactorOut)
        {
            // arrange
            // test cases are arranged above
            ulong inputNumberUL = (ulong)inputNumber;
            ulong factorToFactorOutUL = (ulong)factorToFactorOut;

            // act
            ulong a = _underTest.ExtractFactor(inputNumberUL, factorToFactorOutUL);

            // assert
            return (int)a;
        }

        [TestCase(42, 2, ExpectedResult = 21)]
        [TestCase(462, 2, ExpectedResult = 231)]
        [TestCase(231, 3, ExpectedResult = 77)]
        [TestCase(77, 7, ExpectedResult = 11)]
        public int _05__CheckFactorExtractorForIncompleteFactorization(int inputNumber, int factorToFactorOut)
        {
            // arrange
            // test cases are arranged above
            ulong inputNumberUL = (ulong)inputNumber;
            ulong factorToFactorOutUL = (ulong)factorToFactorOut;

            // act
            ulong a = _underTest.ExtractFactor(inputNumberUL, factorToFactorOutUL);

            // assert
            return (int)a;
        }

        [TestCase(33, 2, ExpectedResult = 33)]
        [TestCase(77, 5, ExpectedResult = 77)]
        [TestCase(125, 3, ExpectedResult = 125)]
        [TestCase(1000, 7, ExpectedResult = 1000)]
        public int _06__CheckFactorExtractorForNoFactorization(int inputNumber, int factorToFactorOut)
        {
            // arrange
            // test cases are arranged above
            ulong inputNumberUL = (ulong)inputNumber;
            ulong factorToFactorOutUL = (ulong)factorToFactorOut;

            // act
            ulong a = _underTest.ExtractFactor(inputNumberUL, factorToFactorOutUL);

            // assert
            return (int)a;
        }
    }
}
