using System;
using DemoApplication.models.general;

namespace DemoApplication.models
{
    public class JuridicalSituation : BaseModel
    {
        public BaseModel Status { get; set; }
        
        public override string ToString(){
            return base.ToString() + "\n" +
                    Status;
        }
    }
}