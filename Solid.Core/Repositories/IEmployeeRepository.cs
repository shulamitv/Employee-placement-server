using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeC>> GetEmployeesAsync();
        Task<EmployeeC> GetEmployeeAsync(int id);
        Task<EmployeeC> AddEmployeeAsync(EmployeeC employee);
        Task<EmployeeC> UpdateEmployeeAsync(int id, EmployeeC employee);
        void DeleteEmployeeAsync(int id);

    }
}
