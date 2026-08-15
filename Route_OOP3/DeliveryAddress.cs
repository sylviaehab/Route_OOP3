using System;
using System.Collections.Generic;
using System.Text;

namespace Route_OOP3
{
    public struct DeliveryAddress
    {
        public string street;
        public string city;
        public int buildingNumber;

        public DeliveryAddress(string street, string city, int buildingNumber)
        {
            this.street = street;
            this.city = city;
            this.buildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"Street: {street}, City: {city}, Building Number: {buildingNumber}";
        }
    }
}