using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IDepartmentService
    {
        IQueryable<Department> GetDeparments();
        Department GetDeparment(long id);
        void InsertDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);
    }
}
