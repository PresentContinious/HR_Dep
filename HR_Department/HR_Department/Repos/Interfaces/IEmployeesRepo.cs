using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Department.Models;

namespace HR_Department.Repos.Interfaces
{
    public interface IEmployeesRepo
    {
        List<Employee> GetAllEmployees();
        List<Employee> GetEmployeesByDep(int depId);
        Employee GetSingleEmployee(int empId);
        void AddNewEmployee(Employee newEmp);
        void DelExistingEmployee(int empId);
        void EditExistingEmployee(int empId, Employee chagedEmp);
    }
}
