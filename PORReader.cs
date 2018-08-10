using System;
using System.Text;
using System.IO;
using System.Xml;
using Telefonica;

namespace Telefonica {
    public class PORReader {
    public readonly XmlNode root;
    private readonly XmlNamespaceManager nsmgr;
    public PORReader(string documentPath){ 
        var xmlDocumentParser = new XmlDocumentParser(documentPath);
        root = xmlDocumentParser.Root;
        nsmgr = xmlDocumentParser.Nsmgr;  
    }

    public object getPurchaseOrder(){

        XmlNode node = root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='SAO']/udc:Identifier", nsmgr);
        return returnNode(node.InnerXml);
    }

        private object returnNode(object node){
            if (node != null) {
                return node;
            } else {
                return "Error in Node";
            }
        }
    }
}