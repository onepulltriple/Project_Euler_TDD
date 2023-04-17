using FluentAssertions;
using NUnit.Framework;
using ProjectEuler._001__Multiples_of_3_or_5;

namespace ProjectEuler.Tests._001__Multiples_of_3_or_5_Tests
{
    [TestFixture]
    public class SummerOf3sAnd5sTests
    {
        //The class being tested:
        SummerOf3sAnd5s _beingTested;

        [SetUp]
        public void SetUp()
        {
            _beingTested = new SummerOf3sAnd5s();
        }

        [Test]
        public void Test01()
        {
            // arrange (could get pretty big)

            // act (should be a single line or call)
            int a = _beingTested.FindSumBelowExcluding(10);

            // assert
            a.Should().Be(23);
        }

    }
}
