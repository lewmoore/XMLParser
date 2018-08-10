namespace Telefonica {
    using NUnit.Framework;
    using Telefonica.Parser;
    using Telefonica.Smip.Reader;

    [TestFixture]
    public class PORReaderTest {
        [Test]
        public void getPurchaseOrder(){

            PORReader reader = new PORReader("/Users/moorel/Desktop/Projects/C#/O2/DummyFiles/SupplyChainSourceFiles/POR/POR_SALES_8307_20180201164154.xml");
            Assert.AreEqual(reader.getPurchaseOrder(), "aa036E31tc63qjPfIMJ");
        }
    }
}