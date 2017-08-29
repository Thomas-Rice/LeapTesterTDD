using System;
using NUnit.Framework;

namespace LeapTesterTDD
{
    [TestFixture]
    public class LeapTesterShould
    {
        [Test]
        public void FourIsDivisibleByFour()
        {
            bool result = LeapYearIdentifier.CheckIfDivisibleByFour(4);
            Assert.AreEqual(true, result);
        }

    }

    public static class LeapYearIdentifier
    {
        public static bool CheckIfDivisibleByFour(int i)
        {
            if(i == 4)
                return true;
            throw new NotImplementedException();
        }
    }
}
