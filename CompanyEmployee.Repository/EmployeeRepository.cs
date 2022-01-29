using CompanyEmployee.Contracts;
using CompanyEmployee.Entities;
using CompanyEmployee.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyEmployee.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationContext context) : base(context)
        {
                
        }

        public IEnumerable<Employee> GetEmployees(Guid employeeId, bool trackChanges) =>
            FindByCondition(e => e.CompanyId.Equals(employeeId), trackChanges)
                .OrderBy(e => e.Name);

        public Employee GetEmployee(Guid companyId, Guid id, bool trackChanges) =>
            FindByCondition(e => e.CompanyId.Equals(companyId) && e.Id.Equals(id), trackChanges).FirstOrDefault();

        public void CreateEmployeeForCompany(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }
    }
}
