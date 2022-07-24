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
    public class EmployeesRepo : IEmployeesRepo
    {
        public void AddNewEmployee(Employee newEmp)
        {
            DynamicParameters paramList = new DynamicParameters();
            paramList.Add("@empName", newEmp.EmpName);
            paramList.Add("@birthDay", newEmp.BirthDay);
            paramList.Add("@position", newEmp.Position);
            paramList.Add("@salary", newEmp.Salary);
            paramList.Add("@depId", newEmp.DepId);
            paramList.Add("@imagePath", newEmp.ImagePath);
            QueryManager.ExecuteDml("AddEmployee", paramList);
        }

        public void DelExistingEmployee(int empId)
        {
            DynamicParameters paramList = new DynamicParameters();
            paramList.Add("@empId", empId);
            QueryManager.ExecuteDml("DelEmployee", paramList);
        }

        public void EditExistingEmployee(int empId, Employee chagedEmp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeesByDep(int depId)
        {
            DynamicParameters paramList = new DynamicParameters();
            paramList.Add("@depId", depId);
            return QueryManager.ExecuteSelect<Employee>("GetEmployeesByDep", paramList).ToList();
        }

        public Employee GetSingleEmployee(int empId)
        {
            throw new NotImplementedException();
        }
    }
}
