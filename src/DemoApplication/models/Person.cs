using System;

namespace DemoApplication.models
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public override string ToString(){
            return "FirstName : " + FirstName + "\n" + 
                    "LastName : " + LastName;
        }
    }
}