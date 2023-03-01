using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployee(int id);
        public Task<Employee> GetEmployeeByEmail(string email);
        public Task<Employee> AddEmployee(Employee employee);
        public Task<Employee> UpdateEmployee(Employee employee);
        public Task DeleteEmployee(int id);
    }
}
