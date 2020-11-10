using Core.Data;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DepartmentService : IDepartmentService
    {
        private IRepository<Department> departmentRepository;

        public DepartmentService(IRepository<Department> departmentRepository)
        {
            this.departmentRepository = departmentRepository;

        }
        public void DeleteDepartment(Department department)
        {
            departmentRepository.Delete(department);
        }

        public Department GetDeparment(long id)
        {
            return departmentRepository.GetById(id);
        }

        public IQueryable<Department> GetDeparments()
        {
            return departmentRepository.Table;
        }

        public void InsertDepartment(Department department)
        {
            departmentRepository.Insert(department);
        }

        public void UpdateDepartment(Department department)
        {
            departmentRepository.Update(department);
        }
    }
}
