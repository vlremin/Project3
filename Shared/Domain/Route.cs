using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Shared.Domain
{
    public class Route
    {
        public int ID { get; set; }

        public string Country { get; set; }

        public string Price { get; set; }

        public string NoOfTravellers { get; set; }

        public string LengthOfTrip { get; set; }

        public virtual Traveller TEmail { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
