using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DemoApplication.models.general;

namespace DemoApplication.models
{
    public class Enterprise
    {
        [XmlElement(ElementName = "Number")]
        public int EnterpriseNumber { get; set; }
        public JuridicalSituation JuridicalSituation { get; set; }
        // public object Preriod { get; set; } //TODO: refactor later
        public String TypeOfEnterprise { get; set; }
        public BaseModel JuridicalForm { get; set; }

        [XmlElement("Denomination")]
        public List<BaseModel> Denominations { get; set; }
        public List<Address> Address { get; set; }
        public int BusinessUnits { get; set; }

        [XmlElement("Qualification")]
        public List<BaseModel> Qualifications { get; set; }

        [XmlElement("Activity")]
        public List<Activity> Activities { get; set; }
        
        [XmlElement("Function")]
        public List<Function> Functions { get; set; }

        [XmlElement("LinkedEnterprise")]
        public List<LinkedEnterprise> LinkedEnterprises { get; set; }

        public override string ToString(){
            string str = "EnterpriseNumber : " + EnterpriseNumber + "\n" +
                    JuridicalSituation + "\n" +
                    "TypeOfEnterprise : " + TypeOfEnterprise + "\n" +
                    JuridicalForm + "\n";
            foreach(var denomination in Denominations){
                str += denomination + "\n";
            }
            foreach(var address in Address){
                str += address + "\n";
            }
            str += "BusinessUnits : " + BusinessUnits;
            foreach(var qual in Qualifications){
                str += "\n" + qual;
            }
            foreach(var act in Activities){
                str += "\n" + act;
            }
            foreach(var func in Functions){
                str += "\n" + func;
            }
            foreach(var link in LinkedEnterprises){
                str += "\n" + link;
            }
            return str;
        }
    }
}