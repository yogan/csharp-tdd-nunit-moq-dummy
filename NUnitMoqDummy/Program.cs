using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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

    public interface IClient
    {
        void BeCalled(string magicInput);
    }

    public class Product
    {
        public int GetNum()
        {
            return 42;
        }

        public void CallMe(IClient client)
        {
            client.BeCalled("magic");
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

        [TestMethod]
        public void CallMe_WhenGivenClient_CallsClient()
        {
            var clientMock = new Mock<IClient>();
            var sut = new Product();

            sut.CallMe(clientMock.Object);

            clientMock.Verify(client => client.BeCalled("not really magic"));
        }
    }
}
