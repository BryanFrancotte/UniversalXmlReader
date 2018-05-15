using System.Xml;
using UniversalXmlReader.constant;

namespace UniversalXmlReader.utils
{
    public class ResourceLoader
    {
        public static XmlTextReader CreateXmlReader(string fileName){
            return new XmlTextReader(MyPath.XML + fileName);
        }

        public static XmlDocument XmlLoader(string fileName){
            XmlDocument xmlDoc =  new XmlDocument();
            xmlDoc.Load(fileName);
            return xmlDoc;
        }
    }
}