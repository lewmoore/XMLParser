using System;
using System.Text;
using System.IO;
using System.Xml;
using Telefonica.Parser;

namespace Telefonica
{
    class Program
    {        
        static void Main(string[] args){
            // This will reside in the reader classes
            var xmlDocumentParser = new XmlDocumentParser("/Users/moorel/Desktop/Projects/C#/O2/DummyFiles/SupplyChainSourceFiles/POR/POR_SALES_8307_20180201164154.xml");
            var root = xmlDocumentParser.Root;
            var nsmgr = xmlDocumentParser.Nsmgr;
        }
    }
}