using System;
using System.Collections.Generic;
using System.Text;

namespace Route_OOP3
{
    public abstract  partial class Shipment
    {
        private string trackingCode;
        public static int TotalShipmentsCreated;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }
        public string TrackingCode
        {
            get { return trackingCode; }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))

                    description = value;
            }
        }
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value >= 0)
                    deliveryFee = value;
            }
        }
        public  abstract decimal EstimatedCost
        {
            get ;
        }
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }
        public Shipment(string trackingCode)
     : this(
         trackingCode,
         "Unknown",
         1,
         50,
         new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }
        public Shipment(string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;

            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

            TotalShipmentsCreated++;
        }
      
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }
        public abstract void PrintShipment();
       
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
                Weight = newWeight+extraPackingWeight;
        }
        public abstract Shipment CopyShipment();
        public abstract Shipment ShallowCopy();
        public abstract Shipment DeepCopy();
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status updated to: {newStatus}");
        }
    }
}