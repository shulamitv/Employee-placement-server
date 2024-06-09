using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Servies;

namespace Solid.Servies
{
    public class EmployeeServies : IEmployeeServies
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeServies(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<EmployeeC>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeesAsync();
        }
        public async Task<EmployeeC> GetEmployeeAsync(int id)
        {
            return await _employeeRepository.GetEmployeeAsync(id);
        }
        public async Task<EmployeeC> AddEmployeeAsync(EmployeeC employee)
        {
            return await _employeeRepository.AddEmployeeAsync(employee);
        }
        public async Task<EmployeeC> UpdateEmployeeAsync(int id, EmployeeC employee)
        {
            return await _employeeRepository.UpdateEmployeeAsync(id, employee);
        }
        public async void DeleteEmployeeAsync(int id)
        {
            _employeeRepository.DeleteEmployeeAsync(id);
        }
    }
}