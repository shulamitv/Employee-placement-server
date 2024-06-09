using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        //List<EmployeeC> GetEmployees();
        //EmployeeC GetEmployee(int id);
        //EmployeeC AddEmployee(EmployeeC employee);
        //EmployeeC UpdateEmployee(int id, EmployeeC employee);
        //EmployeeC DeleteEmployee(int id);

        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EmployeeC>> GetEmployeesAsync()
        {
            return await _context.EmployeeList.ToListAsync();
        }
       
        public async Task<EmployeeC> GetEmployeeAsync(int id)
        {
            return await _context.EmployeeList.FirstAsync(u => u.Id == id);
        }
        public async Task<EmployeeC> AddEmployeeAsync(EmployeeC employeeC)
        {
            _context.EmployeeList.Add(employeeC);
            await _context.SaveChangesAsync();
            return employeeC;
        }
        public async Task<EmployeeC> UpdateEmployeeAsync(int id, EmployeeC employee)
        {
            var updateEmployee = _context.EmployeeList.ToList().Find(u => u.Id == id);
            if (employee != null)
            {
                updateEmployee.Name = employee.Name;
                await _context.SaveChangesAsync();
                return updateEmployee;
            }
            return null;
        }
        public async void DeleteEmployeeAsync(int id)
        {
            _context.EmployeeList.Remove(_context.EmployeeList.ToList().Find(e => e.Id == id));
            await _context.SaveChangesAsync();
        }
    }
}
