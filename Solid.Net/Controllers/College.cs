using Microsoft.AspNetCore.Mvc;
using Solid.Core.Servies;
//using Solid.Entities;
using Solid.Core.Models;
using Solid.Servies;
using System.Collections.Generic;
using Solid.Net.Models;
using AutoMapper;
using Solid.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class College : ControllerBase
    {
        private readonly ICollegeServies _collegeService;
        private readonly IMapper _mapper;
        public College(ICollegeServies collegeSrervice, IMapper mapper)
        {
           _collegeService = collegeSrervice;
            _mapper = mapper;
        }
        // GET: api/<College>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list= await _collegeService.GetCollegesAsync();
            var listDto=_mapper.Map<IEnumerable<CollegeDto>>(list);
            return Ok(listDto); 
        }

        // GET api/<College>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var college = await _collegeService.GetCollegeAsync(id);
            var collegeDto=_mapper.Map<CollegeDto>(college);
            return Ok(collegeDto);
        }

        //// POST api/<College>
        [HttpPost]
        public async Task<CollegeC> AddCollegeAsync([FromBody] CollegePostModel college)
        {
            var collegeToAdd=new CollegeC() { Id=college.Id,Name=college.Name};
            return await _collegeService.AddCollegeAsync(collegeToAdd);
        }
        [HttpPut]
        public async Task<CollegeC> UpdateCollegeAsync(int id, [FromBody] CollegePostModel college)
        {
            var collegeToUpdate = new CollegeC() { Id = college.Id, Name = college.Name };
            return await _collegeService.UpdateCollegeAsync(id, collegeToUpdate);
        }
        [HttpDelete("{id}")]
        public async void DeleteCollegeAsync(int id)
        {
            _collegeService.DeleteCollegeAsync(id);
        }

    
    }
}
