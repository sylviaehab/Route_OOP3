using Route_OOP3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Route_OOP3
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"Tracking Code: {shipment.TrackingCode}, Shipment Type: {shipment.GetType().Name}, Weight: {shipment.Weight}Kg, Tracking Status: {((ITrackable)shipment).GetTrackingStatus()}";
        }
        public static bool IsDeliverable(this Shipment shipment)
        {
            return shipment.GetTrackingStatus() == "Delivered";
        }
    }
}
