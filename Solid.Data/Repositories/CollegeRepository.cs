using Solid.Core.Repositories;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data.Repositories
{
    public class CollegeRepository:ICollegeRepository
    {
        private readonly DataContext _context;
        public CollegeRepository(DataContext context)
        {
            _context=context;
        }
        public async Task<IEnumerable<CollegeC>> GetCollegesAsync()
        {
            return await _context.CollegeList.Include(u => u.Employees).ToListAsync();
        }
        public async Task<CollegeC> GetCollegeAsync(int id)
        {
            return await _context.CollegeList.FirstAsync(u => u.Id == id);
        }
        public async Task<CollegeC> AddCollegeAsync(CollegeC collegeC)
        {
            _context.CollegeList.Add(collegeC);
            await _context.SaveChangesAsync();
            return  collegeC;
        }
        public async Task<CollegeC> UpdateCollegeAsync(int id, CollegeC collegeC)
        {
            var updateCollege=_context.CollegeList.ToList().Find(u => u.Id == id);
            if(collegeC!=null)
            {
                updateCollege.Name=collegeC.Name;
                await _context.SaveChangesAsync();
                return updateCollege;
            }
            return null;
        }
        public async void DeleteCollegeAsync(int id)
        {
            _context.CollegeList.Remove(_context.CollegeList.ToList().Find(e=>e.Id==id));
            await _context.SaveChangesAsync();
        }

    }
}
