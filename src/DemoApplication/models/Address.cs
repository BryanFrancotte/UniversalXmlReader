using System;
using DemoApplication.models.general;

namespace DemoApplication.models
{
    public class Address
    {
        public BaseModel Street { get; set; }
        public String HouseNumber { get; set; }
        public String ZipCode { get; set; }
        public BaseModel Municipality { get; set; }
        public String ExtraAddressInfo { get; set; }
        public String Website { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String FaxNumber { get; set; }
        public BaseModel TypeOfAddress { get; set; }

        public override string ToString(){
            return Street + "\n" +
                    "HouseNumber : " + HouseNumber + "\n" +
                    "ZipCode : " + ZipCode + "\n" +
                    Municipality + "\n" +
                    "ExtraAddressInfo : " + "\n" +
                    "Website : " + Website + "\n" +
                    "Email : " + Email + "\n" +
                    "PhoneNumber : " + PhoneNumber + "\n" +
                    "FaxNumber : " + FaxNumber + "\n" +
                    TypeOfAddress;
        }
    }
}