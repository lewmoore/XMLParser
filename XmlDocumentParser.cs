using System;
using System.Text;
using System.IO;
using System.Xml;


namespace ReportingXML{
    class XmlDocumentParser {
        private string documentPath = "/Users/moorel/Desktop/Projects/C#/O2/DummyFiles/SupplyChainSourceFiles/POR/POR_SALES_8307_20180201164154.xml";
        private string udc = "urn:rosettanet:specification:universal:Document:xsd:schema:01.12";
        private string udct = "urn:rosettanet:specification:universal:DocumentType:xsd:codelist:01.13";
        private string tns = "urn:rosettanet:specification:interchange:PurchaseOrderRequest:xsd:schema:02.05";
        private string dp = "urn:rosettanet:specification:domain:Procurement:xsd:schema:02.29";
        
        public object loadDocument(){
            XmlDocument doc = new XmlDocument();
            doc.Load(documentPath);
            XmlNode root = doc.DocumentElement;
            return root;
        }

            // XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            // nsmgr.AddNamespace("udc", udc); 
            // nsmgr.AddNamespace("udct", udct);
            // nsmgr.AddNamespace("tns", tns);

        
        

    }
}