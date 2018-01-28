using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryRouting.Models
{
    public class DeliveryProgram
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
    }
}
