using System;
using DemoApplication.models.general;

namespace DemoApplication.models
{
    public class LinkedEnterprise : BaseModel
    {
        public String EnterpriseNumberSubject { get; set; }
        public String EnterpriseNumberObject { get; set; }

        public override string ToString(){
            return base.ToString() + "\n" +
                    "EnterpriseNumberSubject : " + EnterpriseNumberSubject + "\n" +
                    "EnterpriseNumberObject : " + EnterpriseNumberObject;
        }
    }
}