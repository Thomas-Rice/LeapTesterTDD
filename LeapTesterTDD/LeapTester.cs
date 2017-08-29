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
}
