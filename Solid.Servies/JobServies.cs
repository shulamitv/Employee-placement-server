using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servies
{
    public class JobServies:IJobServies
    {
        private readonly IJobRepository _JobRepository;
        public JobServies(IJobRepository JobRepository)
        {
            _JobRepository = JobRepository;
        }
        public async Task<IEnumerable<JobC>> GetJobsAsync()
        {
            return await _JobRepository.GetJobsAsync();
        }
        public async Task<JobC> GetJobAsync(int id)
        {
            return await _JobRepository.GetJobAsync(id);
        }
        public async Task<JobC> AddJobAsync(JobC job)
        {
            return await _JobRepository.AddJobAsync(job);
        }
        public async Task<JobC> UpdateJobAsync(int id, JobC job)
        {
            return await _JobRepository.UpdateJobAsync(id, job);
        }
        public async void DeleteJobAsync(int id)
        {
            _JobRepository.DeleteJobAsync(id);
        }
    }
}
