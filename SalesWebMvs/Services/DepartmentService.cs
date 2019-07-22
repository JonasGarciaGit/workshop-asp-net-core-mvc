﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvs.Models;

namespace SalesWebMvs.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvsContext _context;

        public DepartmentService(SalesWebMvsContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
