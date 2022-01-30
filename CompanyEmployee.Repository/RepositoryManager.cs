using CompanyEmployee.Contracts;
using CompanyEmployee.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationContext _context;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        public RepositoryManager(ApplicationContext context)
        {
            _context = context;
        }
        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_context);

                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_context);

                return _employeeRepository;
            }
        }

        public Task SaveAsync() => _context.SaveChangesAsync();
    }
}
