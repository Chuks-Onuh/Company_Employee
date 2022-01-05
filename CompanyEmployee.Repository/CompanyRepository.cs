using CompanyEmployee.Contracts;
using CompanyEmployee.Entities;
using CompanyEmployee.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyEmployee.Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationContext context) : base(context) { }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();
    }
}
