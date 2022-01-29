using CompanyEmployee.Contracts;
using CompanyEmployee.Entities;
using CompanyEmployee.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyEmployee.Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationContext context) : base(context) { }

        public void CreateCompany(Company company) => Create(company);

        public void DeleteCompany(Company company) => Delete(company);

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();

        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();

        public Company GetCompany(Guid CompanyId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(CompanyId), trackChanges).SingleOrDefault();
    }
}
