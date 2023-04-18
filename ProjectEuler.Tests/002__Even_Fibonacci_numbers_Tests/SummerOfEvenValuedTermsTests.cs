using FluentAssertions;
using NUnit.Framework;
using ProjectEuler._002__Even_Fibonacci_numbers;

namespace ProjectEuler.Tests._002__Even_Fibonacci_numbers_Tests
{
    [TestFixture]
    public class SummerOfEvenValuedTermsTests
    {
        // The class being tested.
        SummerOfEvenValuedTerms _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new SummerOfEvenValuedTerms();
        }

        [Test]
        public void _00__ProjectEulerExampleTest()
        {
            // arrange
            int upperLimit = 89;
            int result = 44;

            // act
            int a = _underTest.FindSumOfEvenTermsBelowIncluding(upperLimit);

            // assert
            a.Should().Be(result);
        }

        [TestCase( 2, ExpectedResult =  2)]
        [TestCase(33, ExpectedResult = 10)]
        [TestCase(34, ExpectedResult = 44)]
        public int _01__SelfExamples(int upperLimit)
        {
            // arrange
            // test cases are arranged above

            // act
            int a = _underTest.FindSumOfEvenTermsBelowIncluding(upperLimit);

            // assert
            return a;
        }

        [TestCase(1)]
        [TestCase(-10)]
        public void _02__AOORExceptions(int upperLimit)
        {
            // arrange 
            // test cases are arranged above

            // act 
            Action action = () => _underTest.FindSumOfEvenTermsBelowIncluding(upperLimit);

            // assert 
            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
