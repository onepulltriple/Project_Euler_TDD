using FluentAssertions;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using ProjectEuler._001__Multiples_of_3_or_5;

namespace ProjectEuler.Tests._001__Multiples_of_3_or_5_Tests
{
    [TestFixture]
    public class SummerOf3sAnd5sTests
    {
        //The class being tested:
        SummerOf3sAnd5s _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new SummerOf3sAnd5s();
        }

        [Test]
        public void _00__ProjectEulerExample() 
            // test methods cannot have parameters (unless TestCase attributes are used)
        {
            // arrange (could get pretty big)
            int upperLimit = 10;
            int result = 23;

            // act (should be a single line or call)
            int a = _underTest.FindSumBelowExcluding(upperLimit);

            // assert
            a.Should().Be(result);
        }

        [TestCase(12, ExpectedResult = 33)]
        [TestCase(4, ExpectedResult = 3)]
        public int _01__SelfExamples(int upperLimit)
        {
            // arrange 
            // test cases are arranged above

            // act 
            int a = _underTest.FindSumBelowExcluding(upperLimit);

            // assert
            return a;
        }

        [TestCase(2)]
        [TestCase(-10)]
        public void _02__AOORExceptions(int upperLimit)
        {
            // arrange 
            // test cases are arranged above

            // act 
            Action action = () => _underTest.FindSumBelowExcluding(upperLimit);

            // assert 
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

    }
}
