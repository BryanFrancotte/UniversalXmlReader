using System;
using DemoApplication.models.general;

namespace DemoApplication.models
{
    public class Function : BaseModel
    {
        public Person Person { get; set; }
        public String EnterpriseNumber { get; set; }

        public override string ToString(){
            return base.ToString() + "\n" +
                    Person + "\n" +
                    "EnterpriseNumber : " + EnterpriseNumber;
        }
    }
}