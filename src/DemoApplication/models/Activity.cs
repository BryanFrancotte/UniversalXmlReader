using System;
using DemoApplication.models.general;

namespace DemoApplication.models
{
    public class Activity : BaseModel
    {
        public String AdministrationCode { get; set; }
        public int Version { get; set; }
        public BaseModel ActivityClassification { get; set; }

        public override string ToString(){
            return base.ToString() + "\n" +
                    "AdministrationCode : " + AdministrationCode + "\n" +
                    "Version : " + Version + "\n" +
                    ActivityClassification;
        }
    }
}