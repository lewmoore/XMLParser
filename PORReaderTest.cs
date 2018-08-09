namespace Telefonica {
    using NUnit.Framework;

    [TestFixture]
    public class PORReaderTest {
        [Test]
        public void getPurchaseOrder(){
            PORReader porreader = new PORReader(); 

         Assert.AreEqual("aa036E31tc63qjPfIMJ", porreader.getPurchaseOrder());
        }

    }

}