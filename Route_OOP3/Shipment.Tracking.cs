using System;
using System.Collections.Generic;
using System.Text;

namespace Route_OOP3
{
    public  abstract  partial class Shipment
    {
        private string trackingStatus = "Pending";
        public string TrackingStatus
        {
            get { return trackingStatus; }
        }

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }
        public void UpdateTrackingStatues(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;
                OnTrackingStatusChanged(newStatus);
            }
        }
        partial void OnTrackingStatusChanged(string newStatus);
    }
}
