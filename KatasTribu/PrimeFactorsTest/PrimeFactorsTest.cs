using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
namespace PrimeFactorsTest
{
    public class Tests
    {
        private static IList<int?> List(params int[] ints) => ints.Select(i => (int?)i).ToList();
        /// <summary>
        /// Testones this instance.
        /// </summary>
        [Test]
        public void Testone() => Assert.That(List(), Is.EqualTo(PrimeFactors.Generate(1)));
        /// <summary>
        /// Testwoes this instance.
        /// </summary>
        [Test]
        public void Testwo() => Assert.That(List(2), Is.EqualTo(PrimeFactors.Generate(2)));
        /// <summary>
        /// Testhrees this instance.
        /// </summary>
        [Test]
        public void Testhree() => Assert.That(List(3), Is.EqualTo(PrimeFactor.Generate(3)));
        /// <summary>
        /// Tesfours this instance.
        /// </summary>
        [Test]
        public void Tesfour() => Assert.That(List(2, 2), Is.EqualTo(PrimeFactor.Generate(4)));
        /// <summary>
        /// Tests the six.
        /// </summary>
        [Test]
        public void TestSix() => Assert.That(List(2, 3), Is.EqualTo(PrimeFactor.Generate(6)));
        /// <summary>
        /// Tests the eight.
        /// </summary>
        [Test]
        public void TestEight() => Assert.That(List(2, 2, 2), Is.EqualTo(PrimeFactor.Generate(8)));
        /// <summary>
        /// Tests the nine.
        /// </summary>
        [Test]
        public void TestNine() => Assert.That(List(3, 3), Is.EqualTo(PrimeFactors.Generate(9)));

        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();

        //}
    }
}