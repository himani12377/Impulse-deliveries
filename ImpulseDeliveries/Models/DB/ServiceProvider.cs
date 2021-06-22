using System;
using System.Collections.Generic;

#nullable disable

namespace ImpulseDeliveries.Models.DB
{
    public partial class ServiceProvider
    {
        public string ServiceProviderId { get; set; }
        public string Name { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string Username { get; set; }
        public string BankAccNumber { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
    }
}
