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

        [Test]
        public void getOrderDateTime(){
            Assert.AreEqual(reader.getOrderDateTime(), "2018-02-01T15:03:00Z");
        }

        [Test]
        public void getVariantType(){
            Assert.AreEqual(reader.getVariantType(), "1MESHUB001N");
        }

        [Test]
        public void getDeliveryDateTimeBegin(){
            Assert.AreEqual(reader.getDeliveryDateTimeBegin(), "2018-07-03T09:03:00Z");
        }

        [Test]
        public void getDeliveryDateTimeEnd(){
            Assert.AreEqual(reader.getDeliveryDateTimeEnd(), "2018-07-03T09:13:00Z");
        }
    }
}