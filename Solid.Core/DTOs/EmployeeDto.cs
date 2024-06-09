using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Experience { get; set; }
        public string Profession { get; set; }
        //public bool Status { get; set; }
        public int JobId { get; set; }
        public int CollegeCId { get; set; }
        //public int JobId { get; set; }
    }
}
