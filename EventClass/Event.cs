using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClass
{
    public class Event
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string GenCon { get; set; }
        public int Capacity { get; set; }
        public int PriceOfAdmission { get; set; }
        
    }
}
