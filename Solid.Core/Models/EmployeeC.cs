using Solid.Core.Models;


namespace Solid.Core.Models
{
    public class EmployeeC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Experience { get; set; }
        public string Profession { get; set; }
        //public bool Status { get; set; }
        public int CollegeCId { get; set; }  
        public int JobId { get; set; }  
        //public CollegeC CollegeC { get; set; }
        //public List<JobC> Jobs { get; set; }
        //public JobC Job { get; set; }
    }
}
