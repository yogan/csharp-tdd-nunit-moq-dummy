using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitMoqDummy
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Product
    {
        public int GetNum()
        {
            return 42;
        }
    }

    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void GetNum_WhenCalled_Returns42()
        {
            var sut = new Product();

            Assert.That(sut.GetNum(), Is.EqualTo(42 + 23));
        }
    }
}
