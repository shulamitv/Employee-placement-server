namespace Solid.Core.Models
{
    public class JobC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int HoursInDay { get; set; }
        public List<EmployeeC> Employees { get; set; }
        public List<CollegeC> Colleges { get; set; }
    }
}
