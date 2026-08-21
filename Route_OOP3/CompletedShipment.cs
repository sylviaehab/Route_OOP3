using System;
using System.Collections.Generic;
using System.Text;

namespace Route_OOP3
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
             string trackingCode,
             string description,
             decimal weight,
             decimal deliveryFee,
             DeliveryAddress destination)
             : base(
                 trackingCode,
                 description,
                 weight,
                 deliveryFee,
                 destination)
        {
        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override Shipment CopyShipment()
        {
            throw new NotImplementedException();
        }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
        public override Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public override Shipment DeepCopy()
        {
            return new StandardShipment(TrackingCode, Description, Weight, DeliveryFee, new DeliveryAddress(Destination.city, Destination.street, Destination.buildingNumber));
        }
    }
}
