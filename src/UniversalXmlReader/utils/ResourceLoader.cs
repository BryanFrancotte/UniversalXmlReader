using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UniversalXmlReader.constant;
using UniversalXmlReader.models;

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

        public static string XmlToStringLoader(string fileName){
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);
            return xmlDoc.InnerXml;
        }

        public static void StructureLoader(string fileName){
            StreamReader structFile = new StreamReader(MyPath.STRUCT + fileName);
            string line;
            List<NodeName> CustomObjectList = new List<NodeName>();
            while((line = structFile.ReadLine()) != null){
                string[] splitedLine = line.Split(' ');
                Console.Write("|");
                for(int i = 0; i < splitedLine.Length; i++){
                    splitedLine[i] = splitedLine[i].Replace("\t", "");
                    Console.Write(splitedLine[i] + "|");
                }
                Console.WriteLine("");
            }
            structFile.Close();
        }
    }
}