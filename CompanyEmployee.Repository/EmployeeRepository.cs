using CompanyEmployee.Contracts;
using CompanyEmployee.Entities;
using CompanyEmployee.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyEmployee.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationContext context) : base(context)
        {
                
        }
    }
}
