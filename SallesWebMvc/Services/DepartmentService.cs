﻿using SallesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SallesWebMvcContext _context;

        public DepartmentService(SallesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}
