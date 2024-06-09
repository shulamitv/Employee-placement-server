using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class JobDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int HoursInDay { get; set; }
    }
}
