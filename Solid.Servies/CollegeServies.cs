using Solid.Core.Repositories;
using Solid.Core.Servies;
//using Solid.Entities;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servies
{

    public class CollegeServies : ICollegeServies
    {
        private readonly ICollegeRepository _collegeRepository;

        public CollegeServies(ICollegeRepository collegeRepository)
        {
            _collegeRepository = collegeRepository;
        }
        public async Task<IEnumerable<CollegeC>> GetCollegesAsync()
        {
            return await _collegeRepository.GetCollegesAsync();
        }
        public async Task<CollegeC> GetCollegeAsync(int id)
        {
            return await _collegeRepository.GetCollegeAsync(id);
        }
        public async Task<CollegeC> AddCollegeAsync(CollegeC collegeC)
        {
            return await _collegeRepository.AddCollegeAsync(collegeC);
        }

        public async Task<CollegeC> UpdateCollegeAsync(int id, CollegeC collegeC)
        {
            return await _collegeRepository.UpdateCollegeAsync(id, collegeC);
        }
        public async void DeleteCollegeAsync(int id)
        {
            _collegeRepository.DeleteCollegeAsync(id);
        }
    }
}
