using System;
using System.Text;
using System.IO;
using System.Xml;


namespace ReportingXML
{
    class Program
    {
        static void Main(string[] args){
            var xml = new Program();
            Console.WriteLine(xml.getPurchaseOrder());
        }

        public object getPurchaseOrder(){
           XmlDocument doc = new XmlDocument();
            doc.Load("/Users/moorel/Desktop/Projects/C#/O2/DummyFiles/SupplyChainSourceFiles/POR/POR_SALES_8307_20180201164154.xml");
            XmlNode root = doc.DocumentElement;

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);  
            nsmgr.AddNamespace("udc", "urn:rosettanet:specification:universal:Document:xsd:schema:01.12"); 
            nsmgr.AddNamespace("udct", "urn:rosettanet:specification:universal:DocumentType:xsd:codelist:01.13");
            nsmgr.AddNamespace("tns", "urn:rosettanet:specification:interchange:PurchaseOrderRequest:xsd:schema:02.05");

            XmlNode node = root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='SAO']/udc:Identifier", nsmgr);
            if (node != null) {
                return node.InnerXml;
            } else {
                return "Error in Node";
            }
        }
    }
}
