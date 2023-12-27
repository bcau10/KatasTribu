using NUnit.Framework;
namespace RomanNumeralsTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestConvertisseur()
        {
            int nombre = 15;
            string resultat = "xv";
            Assert.Equals(RomanNumerals.EnChiffreRomain(nombre), resultat);
        }
    }
}