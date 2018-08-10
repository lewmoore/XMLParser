namespace Telefonica {
    using NUnit.Framework;
    using Telefonica;

    [TestFixture]
    public class PORReaderTest {
    PORReader reader = new PORReader("/Users/moorel/Desktop/Projects/C#/O2/DummyFiles/SupplyChainSourceFiles/POR/POR_SALES_8307_20180201164154.xml");

        [Test]
        public void getPurchaseOrder(){
            Assert.AreEqual(reader.getPurchaseOrder(), "aa036E31tc63qjPfIMJ");
        }

        [Test]
        public void getChildOrder(){
            Assert.AreEqual(reader.getChildOrder(), "ORDER00054491-CONS1");
        }

        [Test]
        public void getOrderVolume(){
            Assert.AreEqual(reader.getOrderVolume(), "2.0");
        }
    }
}