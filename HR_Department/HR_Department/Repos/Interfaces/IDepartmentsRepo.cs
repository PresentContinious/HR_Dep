using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Department.Models;

namespace HR_Department.Repos.Interfaces
{
    public interface IDepartmentsRepo
    {
        List<Department> GetAllDepartments();
        Department GetSingleDepartment(int depId);
        void AddNewDepartment(Department newDep);
        void DelExistingDepartment(int depId);
        void EditExistingDepartment(int depId, Department chagedDep);
    }
}
