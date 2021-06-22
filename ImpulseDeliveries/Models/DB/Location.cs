using System;
using System.Collections.Generic;

#nullable disable

namespace ImpulseDeliveries.Models.DB
{
    public partial class Location
    {
        public Location()
        {
            Requests = new HashSet<Request>();
        }

        public int TrackingNumber { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
