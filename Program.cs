using System;
using System.Text;
using System.IO;
using System.Xml;


namespace ReportingXML
{
    class Program
    {

        private string udc = "urn:rosettanet:specification:universal:Document:xsd:schema:01.12";
        private string udct = "urn:rosettanet:specification:universal:DocumentType:xsd:codelist:01.13";
        private string tns = "urn:rosettanet:specification:interchange:PurchaseOrderRequest:xsd:schema:02.05";
        private string dp = "urn:rosettanet:specification:domain:Procurement:xsd:schema:02.29";
        private string documentPath = "/Users/moorel/Desktop/Projects/C#/O2/DummyFiles/SupplyChainSourceFiles/POR/POR_SALES_8307_20180201164154.xml";
        XmlDocument doc = new XmlDocument();
        
        static void Main(string[] args){
            var xml = new Program();
            Console.WriteLine(xml.getPurchaseOrder());
            Console.WriteLine(xml.getChildOrderID());
            Console.WriteLine(xml.getOrderVolume());
        }

        public object getPurchaseOrder(){
            doc.Load(documentPath);
            XmlNode root = doc.DocumentElement;
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("udc", udc); 
            nsmgr.AddNamespace("udct", udct);
            nsmgr.AddNamespace("tns", tns);

            XmlNode node = root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='SAO']/udc:Identifier", nsmgr);
             return returnNode(node.InnerXml);
        }

        public object getChildOrderID(){
            doc.Load(documentPath);
            XmlNode root = doc.DocumentElement;
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("udc", udc); 
            nsmgr.AddNamespace("udct", udct);
            nsmgr.AddNamespace("tns", tns);

            XmlNode node = root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='DOR']/udc:Identifier", nsmgr);
            return returnNode(node.InnerXml);
        }

        public object getOrderVolume(){
            doc.Load(documentPath);
            XmlNode root = doc.DocumentElement;
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable); 
            nsmgr.AddNamespace("tns", tns);
            nsmgr.AddNamespace("dp", dp);

            XmlNode node = root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/tns:OrderLineItem/tns:ProductLineItem/dp:OrderQuantity/dp:RequestedQuantity", nsmgr);
            return returnNode(node.InnerXml);
        }

        public object returnNode(object node){
            if (node != null) {
                return node;
            } else {
                return "Error in Node";
            }
        }
    }
}
