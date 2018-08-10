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

            return root.SelectSingleNode(
                    "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='SAO']/udc:Identifier", nsmgr).InnerXml;
        }

        public object getChildOrder(){
            return root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='DOR']/udc:Identifier", nsmgr).InnerXml;
        }

        public object getOrderVolume(){
            return root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/tns:OrderLineItem/tns:ProductLineItem/dp:OrderQuantity/dp:RequestedQuantity", nsmgr).InnerXml;
        }

        public object getOrderDateTime(){
            return root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/udc:BusinessDocumentReference[udct:DocumentType='DOR']/udc:DateTime", nsmgr).InnerXml;
        }

        public object getVariantType(){
            return root.SelectSingleNode(
                "descendant::tns:PurchaseOrder/tns:OrderLineItem/tns:ProductLineItem/updi:ProductIdentification/ulc:AlternativeIdentifier/ulc:Identifier", nsmgr
            ).InnerXml;
        }
    }
}