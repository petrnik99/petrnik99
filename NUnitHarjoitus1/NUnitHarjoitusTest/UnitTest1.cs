using NUnit.Framework;
using NUnitHarjoitus1;

namespace NUnitHarjoitustTest
{
    public class Tests
    {
        Kertoja kerro;
        [SetUp]
        public void Setup()
        {
            kerro = new Kertoja();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        public void LukujenSumma()
        {
            int tulo = kerro.Kerro(5, 10);
            Assert.AreEqual(50, tulo);
        }
    }
}