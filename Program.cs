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
            Console.WriteLine(xml.getXml());
        }

        public object getXml(){
           XmlDocument doc = new XmlDocument();
            doc.Load("/Users/moorel/Desktop/Projects/C#/O2/DummyFiles/SupplyChainSourceFiles/POR/POR_SALES_8307_20180201164154.xml");
            XmlNode root = doc.DocumentElement;

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);  
            nsmgr.AddNamespace("sshd", "urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:01.23"); 

            XmlNode node = root.SelectSingleNode(
                "descendant::sshd:DocumentHeader/sshd:DocumentInformation/sshd:Creation", nsmgr);
                
            return node.InnerXml;
        }
    }
}
