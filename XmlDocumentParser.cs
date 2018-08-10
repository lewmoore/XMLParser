using System;
using System.Text;
using System.IO;
using System.Xml;

namespace Telefonica.Parser
{
    public class XmlDocumentParser
    {
        // This is a private instance variable that cannot be reassigned
        private readonly XmlDocument document = new XmlDocument();
        private string udc = "urn:rosettanet:specification:universal:Document:xsd:schema:01.12";
        private string udct = "urn:rosettanet:specification:universal:DocumentType:xsd:codelist:01.13";
        private string tns = "urn:rosettanet:specification:interchange:PurchaseOrderRequest:xsd:schema:02.05";
        private string dp = "urn:rosettanet:specification:domain:Procurement:xsd:schema:02.29";
        
        //This is the constructor
        public XmlDocumentParser(string documentPath)
        {
            document.Load(documentPath);
            XmlNode Root = document.DocumentElement;
            XmlNamespaceManager Nsmgr = new XmlNamespaceManager(document.NameTable);
            Nsmgr.AddNamespace("udc", udc); 
            Nsmgr.AddNamespace("udct", udct);
            Nsmgr.AddNamespace("tns", tns);
        }
        
        // This is a public property that can only be read and not set
        public XmlNode Root { private set; get; }
        public XmlNode Nsmgr {private set; get; }
    }
}