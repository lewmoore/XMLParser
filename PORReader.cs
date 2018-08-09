using System;
using System.Text;
using System.IO;
using System.Xml;

namespace Telefonica {
    public class PORReader {
        
    private readonly XmlNode root;
    public object getPurchaseOrder(){
        return root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='SAO']/udc:Identifier").InnerXml;
        }
    }
}