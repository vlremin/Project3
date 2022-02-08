using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Shared.Domain
{
    public class Trip
    {
        public int ID { get; set; }

        public string Details { get; set; }

        public virtual Traveller TEmail { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
