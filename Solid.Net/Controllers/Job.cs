using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Net.Http.Headers;
using Solid.Core.DTOs;
using Solid.Core.Models;
using Solid.Core.Servies;
using Solid.Net.Models;
using Solid.Servies;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebApplication1;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace WebApplication1.Controllers.Job
{

    [Route("api/[controller]")]
    [ApiController]
    public class Job : ControllerBase
    {
        private readonly IJobServies _jobServies;
        private readonly IMapper _mapper;   
        public Job(IJobServies jobServies,IMapper mapper)
        {
            _jobServies = jobServies;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var list =await _jobServies.GetJobsAsync();
            var listDto = _mapper.Map<IEnumerable<JobDto>>(list);
            return Ok(listDto);
        }

        // GET: api/<Job>
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var job = _jobServies.GetJobAsync(id);
            var jobDto = _mapper.Map<JobDto>(job);
            return Ok(jobDto);
        }

        // POST api/<College>
        [HttpPost]
        public async Task<JobC> AddCollegeAsync([FromBody]JobPostModel job)
        {
            var jobToAdd=new JobC() { Id=job.Id,Name=job.Name,HoursInDay=job.HoursInDay,Profession=job.Profession};
            return await _jobServies.AddJobAsync(jobToAdd);
        }
        [HttpPut]
        public async Task<JobC> UpdateCollegeAsync(int id, [FromBody] JobPostModel job)
        {
            var jobToUpdate = new JobC() { Id = job.Id, Name = job.Name, HoursInDay = job.HoursInDay, Profession = job.Profession };

            return await _jobServies.UpdateJobAsync(id, jobToUpdate);
        }
        [HttpDelete("{id}")]
        public async void DeleteCollegeAsync(int id)
        {
            _jobServies.DeleteJobAsync(id);
        }

     
    }
}
