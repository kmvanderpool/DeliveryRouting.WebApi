using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryRouting.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteName { get; set; }

        public virtual ICollection<Family> Addresses { get; set; }
    }
}
