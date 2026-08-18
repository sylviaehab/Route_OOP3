using Route_OOP3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Route_OOP3
{
    public class DeliveryCenter

    {
        private Shipment[] shipments;
        public string CenterName { get; set; }
        public Driver Driver { get; set; }
        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;

            shipments = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                else
                    return default;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }

        }
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment != null &&
                        shipment.TrackingCode == trackingCode)
                    {
                        return shipment;
                    }
                }

                return null;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine($"===== {CenterName} =====");

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine("----------------------");

                }
            }
        }

        public void PrintTrackingStatuses()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    ITrackable t = (ITrackable)shipment;

                    Console.WriteLine(t.GetTrackingStatus());
                }
            }
        }
    }
}