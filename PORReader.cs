using System;
using System.Text;
using System.IO;
using System.Xml;
using Telefonica.Parser;

namespace Telefonica.Smip.Reader {
    public class PORReader {
    private readonly XmlNode root;
    private readonly XmlNamespaceManager nsmgr;
    public PORReader(string documentPath){   
        var xmlDocumentParser = new XmlDocumentParser(documentPath);
        this.root = xmlDocumentParser.Root;
    }

    public object getPurchaseOrder(){

        return root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='SAO']/udc:Identifier", nsmgr).InnerXml;
        }
    }
}