using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvs.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvs.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvsContext _context;

        public DepartmentService(SalesWebMvsContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
