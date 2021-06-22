using System;
using System.Collections.Generic;

#nullable disable

namespace ImpulseDeliveries.Models.DB
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PickupAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public string ParcelDimensions { get; set; }
        public string ParcelWeight { get; set; }
        public string Description { get; set; }
        public int TrackingNumber { get; set; }

        public virtual Location TrackingNumberNavigation { get; set; }
    }
}
