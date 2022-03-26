using CodeWars.Core;
using NUnit.Framework;

namespace KataTester
{
    internal class KataTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Odd number below N given var
        /// </summary>
        [Test]
        public void OddNumber()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Assert.AreEqual(7, Kata.OddCount(15));
                Assert.AreEqual(7511, Kata.OddCount(15023));
            }
        }
        
        [Test]
        public void FixedRGB() 
        {
            for (int i = 0; i < 1000000; i++)
            {
                Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 255));
                Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 300));
                Assert.AreEqual("000000", Kata.Rgb(0, 0, 0));
                Assert.AreEqual("9400D3", Kata.Rgb(148, 0, 211));
                Assert.AreEqual("9400D3", Kata.Rgb(148, -20, 211), "Handle negative numbers.");
                Assert.AreEqual("90C3D4", Kata.Rgb(144, 195, 212));
                Assert.AreEqual("D4350C", Kata.Rgb(212, 53, 12), "Consider single hex digit numbers."); 
            }
        }

    }
}
