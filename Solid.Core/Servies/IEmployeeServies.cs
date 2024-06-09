using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servies
{
    public interface IEmployeeServies
    {
        Task<IEnumerable<EmployeeC>> GetEmployeesAsync();
        Task<EmployeeC> GetEmployeeAsync(int id);
        Task<EmployeeC> AddEmployeeAsync(EmployeeC employeeC);
        Task<EmployeeC> UpdateEmployeeAsync(int id, EmployeeC employeeC);
        void DeleteEmployeeAsync(int id);
    }
}
