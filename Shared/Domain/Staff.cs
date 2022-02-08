using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Shared.Domain
{
    public class Staff
    {
        public int ID { get; set; }
        public int StaffID { get; set; }

        public string StaffPassword { get; set; }

        public string StaffEmail { get; set; }

        public virtual Traveller TEmail { get; set; }
    }
}
