using System;
using DemoApplication.models;
using UniversalXmlReader;
using UniversalXmlReader.utils;

namespace DemoApplication.logic
{
    public class Logic
    {
        public static void ExecuteLogic(string[] args){
            var docXml = ResourceLoader.XmlLoader("./res/xml/KBOtest.xml");
            var nodeList = docXml.GetElementsByTagName("ReadEnterpriseReply");
            var str = nodeList[0].InnerXml;
            str = str.Replace("ns2:", "");
            var enterprise = Serializer.Deserialize<Enterprise>(str);
            Console.WriteLine(enterprise);
        }
    }
}