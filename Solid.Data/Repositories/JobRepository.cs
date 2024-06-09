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
    public class JobRepository:IJobRepository
    {

        //List<JobC> GetJobs();
        //JobC GetJob(int id);
        //JobC AddJob(JobC job);
        //JobC UpdateJob(int id, JobC job);
        //void DeleteJob(int id);
        private readonly DataContext _context;
        public JobRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<JobC>> GetJobsAsync()
        {
            return await _context.JobList.Include(u => u.Employees).Include(u=>u.Colleges).ToListAsync();
        }
        public async Task<JobC> GetJobAsync(int id)
        {
            return await _context.JobList.FirstAsync(u => u.Id == id);
        }
        public async Task<JobC> AddJobAsync(JobC jobC)
        {
            _context.JobList.Add(jobC);
            await _context.SaveChangesAsync();
            return jobC;
        }
        public async Task<JobC> UpdateJobAsync(int id, JobC jobC)
        {
            var updateJob = _context.JobList.ToList().Find(u => u.Id == id);
            if (jobC != null)
            {
                updateJob.Name = jobC.Name;
                await _context.SaveChangesAsync();
                return updateJob;
            }
            return null;
        }
        public async void DeleteJobAsync(int id)
        {
            _context.JobList.Remove(_context.JobList.ToList().Find(e => e.Id == id));
            await _context.SaveChangesAsync();
        }
    }
}
