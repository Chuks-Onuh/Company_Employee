using CompanyEmployee.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyEmployee.Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(Guid CompanyId, bool trackChanges);
        void CreateCompany(Company company);
        IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    }
}
