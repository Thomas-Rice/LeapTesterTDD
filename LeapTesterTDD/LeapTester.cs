using System;
using NUnit.Framework;

namespace LeapTesterTDD
{
    [TestFixture]
    public class LeapTesterShould
    {

        [TestCase(4, ExpectedResult = true)]
        [TestCase(8, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = true)]
        [TestCase(16, ExpectedResult = true)]

        [TestCase(3, ExpectedResult = false)]
        [TestCase(6, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]

        public bool IsDivisibleByFour(int value)
        {
            return LeapYearIdentifier.CheckIfDivisibleByFour(value);
        }

        [TestCase(4, ExpectedResult = false)]
        public bool IsDivisibleByOneHundred(int value)
        {
            return LeapYearIdentifier.CheckIfDivisibleByOneHundred(value);
        }

    }

    public static class LeapYearIdentifier
    {
        public static bool CheckIfDivisibleByFour(int i)
        {
            return i % 4 == 0;
        }

        public static bool CheckIfDivisibleByOneHundred(int value)
        {
                return false;
        }
    }
}
