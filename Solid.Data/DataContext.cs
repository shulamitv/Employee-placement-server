using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
//using Solid.Entities;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CollegeC> CollegeList { get; set; }
        public DbSet<EmployeeC> EmployeeList { get; set; }
        public DbSet<JobC> JobList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }

        //public DataContext()
        //{
        //    CollegeList = new List<CollegeC>();
        //    CollegeList.Add(new CollegeC() { Id=1,Name="wolf"});
        //    EmployeeList = new List<EmployeeC>();
        //    EmployeeList.Add(new EmployeeC() { Id = 2, Name = "yael" });
        //    JobList = new List<JobC>();
        //    JobList.Add(new JobC() { Id = 1, Name = "programing" });
        //}
    }
}