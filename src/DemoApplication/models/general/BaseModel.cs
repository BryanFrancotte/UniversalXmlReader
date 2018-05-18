using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DemoApplication.models.general
{
    public class BaseModel
    {
        public String Code { get; set; }

        [XmlElement("Description")]
        public List<Description> Descriptions { get; set; }
        
        public override string ToString(){
            string str = "Code : " + Code;
            foreach(var descr in Descriptions){
                str += "\n" + descr;
            }
            return str;
        }
    }
}