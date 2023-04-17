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

        [Test]
        public void Test02()
        {
            // arrange 

            // act 
            int a = _beingTested.FindSumBelowExcluding(12);

            // assert
            a.Should().Be(33);
        }

        [Test]
        public void Test03()
        {
            // arrange 

            // act 
            int a = _beingTested.FindSumBelowExcluding(4);

            // assert
            a.Should().Be(3);
        }

        [Test]
        public void Test04()
        {
            // arrange 

            // act 
            int a = _beingTested.FindSumBelowExcluding(2);

            // assert
            a.Should().Be(-1);
        }

        [Test]
        public void Test05()
        {
            // arrange 

            // act 
            int a = _beingTested.FindSumBelowExcluding(-10);

            // assert
            a.Should().Be(-1);
        }
    }
}
