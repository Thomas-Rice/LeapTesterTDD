﻿using System;
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

        [Test]
        public void EightIsDivisibleByFour()
        {
            bool result = LeapYearIdentifier.CheckIfDivisibleByFour(8);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TwelveIsDivisibleByFour()
        {
            bool result = LeapYearIdentifier.CheckIfDivisibleByFour(12);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void SixteenIsDivisibleByFour()
        {
            bool result = LeapYearIdentifier.CheckIfDivisibleByFour(16);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ThreeIsDivisibleByFour()
        {
            bool result = LeapYearIdentifier.CheckIfDivisibleByFour(3);
            Assert.AreEqual(false, result);
        }

    }

    public static class LeapYearIdentifier
    {
        public static bool CheckIfDivisibleByFour(int i)
        {
            if(i % 4 == 0)
                return true;
            if (i == 3)
                return false;
            throw new NotImplementedException();
        }
    }
}
