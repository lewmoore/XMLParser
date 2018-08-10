using System;
using System.Text;
using System.IO;
using System.Xml;

namespace Telefonica
{
    public class XmlDocumentParser
    {
        // This is a private instance variable that cannot be reassigned
        private readonly XmlDocument document = new XmlDocument();
        public string udc = "urn:rosettanet:specification:universal:Document:xsd:schema:01.12";
        public string udct = "urn:rosettanet:specification:universal:DocumentType:xsd:codelist:01.13";
        public string tns = "urn:rosettanet:specification:interchange:PurchaseOrderRequest:xsd:schema:02.05";
        public string dp = "urn:rosettanet:specification:domain:Procurement:xsd:schema:02.29";
        public string updi = "urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:01.04";
        public string ulc = "urn:rosettanet:specification:universal:Locations:xsd:schema:01.04";
        
        //This is the constructor
        public XmlDocumentParser(string documentPath)
        {
            document.Load(documentPath);
            Root = document.DocumentElement as XmlNode;
            Nsmgr = new XmlNamespaceManager(document.NameTable);
            Nsmgr.AddNamespace("udc", udc); 
            Nsmgr.AddNamespace("udct", udct);
            Nsmgr.AddNamespace("tns", tns);
            Nsmgr.AddNamespace("dp", dp);
            Nsmgr.AddNamespace("updi", updi);
            Nsmgr.AddNamespace("ulc", ulc);
        }
        
        // This is a public property that can only be read and not set
        public XmlNode Root { get; }
        public XmlNamespaceManager Nsmgr { get; }
    }
}