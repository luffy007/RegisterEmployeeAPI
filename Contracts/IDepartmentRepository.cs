using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDepartmentRepository
    {
        public Task<IEnumerable<Department>> GetDepartments();
        public Task<Department> GetDepartment(int id);
    }
}
