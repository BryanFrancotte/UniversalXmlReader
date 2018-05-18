using System.IO;
using System.Xml.Serialization;

namespace UniversalXmlReader
{
    public class Serializer
    {
        public static T Deserialize<T>(string xmlInput) 
        where T : class{
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using(StringReader strReader = new StringReader(xmlInput)){
                return (T)xmlSerializer.Deserialize(strReader); 
            }
        }

        public static string Serialize<T>(T ObjectToSerialize){
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            using(StringWriter strWriter = new StringWriter()){
                xmlSerializer.Serialize(strWriter, ObjectToSerialize);
                return strWriter.ToString();
            }
        }
    }
}