using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICollegeRepository
    {
        Task<IEnumerable<CollegeC>> GetCollegesAsync();
        Task<CollegeC> GetCollegeAsync(int id);
        Task<CollegeC> AddCollegeAsync(CollegeC collegeC);
        Task<CollegeC> UpdateCollegeAsync(int id, CollegeC collegeC);
        void DeleteCollegeAsync(int id);
    }
}
