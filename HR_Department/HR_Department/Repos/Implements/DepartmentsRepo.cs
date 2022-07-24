using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Department.Repos.Interfaces;
using HR_Department.Models;
using HR_Department.Dapper;
using Dapper;

namespace HR_Department.Repos.Implements
{
    public class DepartmentsRepo : IDepartmentsRepo
    {
        public void AddNewDepartment(Department newDep)
        {
            throw new NotImplementedException();
        }

        public void DelExistingDepartment(int depId)
        {
            throw new NotImplementedException();
        }

        public void EditExistingDepartment(int depId, Department chagedDep)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllDepartments()
        {
            return QueryManager.ExecuteSelect<Department>("GetAllDepartments").ToList();
        }

        public Department GetSingleDepartment(int depId)
        {
            throw new NotImplementedException();
        }
    }
}
