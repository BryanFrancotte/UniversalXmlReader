using System;
using System.Xml;
using UniversalXmlReader.utils;

namespace UniversalXmlReader
{
    public class Reader
    {
        public static void ReadAllValue(string fileName){
            XmlReader reader = ResourceLoader.CreateXmlReader(fileName);
            while(reader.Read()){
                if(reader.NodeType == XmlNodeType.Text){
                    Console.WriteLine(reader.Value);
                }
            }
        }
    }
}