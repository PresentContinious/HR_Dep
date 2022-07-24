using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department.ViewModels
{
    public class AppViewModel
    {
        public DepartmentsViewModel DepVm { get; set; } = new DepartmentsViewModel();
        public EmployeesViewModel EmpVm { get; set; } = new EmployeesViewModel();
    }
}
