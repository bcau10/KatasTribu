using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
namespace NUnitTestProject
{
    [TestFixture]
    class RomanNumeralsTest
    {
        [TestCase(5, "V")]
        [TestCase(999, "CMXCIX")]
        [TestCase(1976, "MCMLXXVI")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(1001, "MI")]
        [TestCase(2016, "MMXVI")]

        [Test]
        public void ChiffresRomainsTest(int number, string resultat)
        {
            Assert.AreEqual(RomanNumerals.RomanNumeralsImpl.EnChiffresRomains(number), resultat);
        }
    }
}
