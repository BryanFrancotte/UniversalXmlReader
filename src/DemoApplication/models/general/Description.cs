using System;

namespace DemoApplication.models.general
{
    public class Description
    {
        public String Value { get; set; }
        public String Language { get; set; }
        
        public override string ToString(){
            return "Value : " + Value + "\n"
                + "Language : " + Language;
        }
    }
}