using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class Security
    {
        public int BadgeID { get; set; }
        public List<string> ListOfDoors { get; set; }
        public bool HasSecurityClearance { get; set; }
        public int EmployeeID { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
