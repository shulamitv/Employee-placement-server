using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IJobRepository
    {
        Task<IEnumerable<JobC>> GetJobsAsync();
        Task<JobC> GetJobAsync(int id);
        Task<JobC> AddJobAsync(JobC job);
        Task<JobC> UpdateJobAsync(int id, JobC job);
        void DeleteJobAsync(int id);
    }
}
