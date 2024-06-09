using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Models;
using Solid.Core.Servies;
using Solid.Net.Models;
using System.Collections.Generic;
using WebApplication1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class Employee : ControllerBase
    {
        private  readonly IEmployeeServies _employeeServies;
        private readonly IMapper _mapper;
        public Employee(IEmployeeServies employeeServies,IMapper mapper)
        {
            _employeeServies = employeeServies;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            //return Ok(_employeeServies.GetEmployees());
            var list = await _employeeServies.GetEmployeesAsync();
            var listDto = _mapper.Map<IEnumerable<EmployeeDto>>(list);
            return Ok(listDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var employee = _employeeServies.GetEmployeeAsync(id);
            var employeeDto=_mapper.Map<EmployeeDto>(employee);
            return Ok(employeeDto);
        }

        //// POST api/<College>
        [HttpPost]
        public async Task<EmployeeC> AddCollegeAsync([FromBody] EmployeePostModel employee)
        {
            var employeeToAdd = new EmployeeC() { Id = employee.Id, Name = employee.Name,CollegeCId=employee.CollegeCId, Profession=employee.Profession};
            return await _employeeServies.AddEmployeeAsync(employeeToAdd);
        }
        [HttpPut]
        public async Task<EmployeeC> UpdateCollegeAsync(int id,[FromBody] EmployeePostModel employee)
        {
            var employeeToUpdate = new EmployeeC() { Id = employee.Id, Name = employee.Name, CollegeCId = employee.CollegeCId };

            return await _employeeServies.UpdateEmployeeAsync(id, employeeToUpdate);
        }
        [HttpDelete("{id}")]
        public async void DeleteCollegeAsync(int id)
        {
            _employeeServies.DeleteEmployeeAsync(id);
        }
      
        
    }
}
