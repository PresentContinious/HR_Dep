using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using HR_Department.Repos.Implements;
using HR_Department.Models;
using HR_Department.Commands;
using System.Windows;

namespace HR_Department.ViewModels
{
    public class EmployeesViewModel : INotifyPropertyChanged
    {
        private readonly EmployeesRepo _empRepo;
        public ObservableCollection<Employee> Employees { get; set; }

        private Employee _selectedEmployee;
        public Employee SelectedEmployee 
        {
            get { return _selectedEmployee; }
            set { _selectedEmployee = value; OnPropertyChanged("SelectedEmployee"); }
        }

        public EmployeesViewModel() 
        {
            _empRepo = new EmployeesRepo();
            Employees = new ObservableCollection<Employee>();
        }

        private RelayCommand _addEmployee;
        public RelayCommand AddEmployee 
        {
            get 
            {
                return _addEmployee ?? (_addEmployee = new RelayCommand(obj =>
                {
                    Department selDep = obj as Department;
                    Employee newEmptyEmployee = new Employee()
                    {
                        Id = 0,
                        EmpName = "New Employee",
                        BirthDay = new DateTime(1970, 1, 1),
                        Position = "New Position",
                        Salary = 700,
                        DepId = selDep.Id,
                        ImagePath = "../Images/profile.png"
                    };
                    Employees.Add(newEmptyEmployee);
                    SelectedEmployee = newEmptyEmployee;
                }));
            }
        }

        public void LoadEmployeesByDepartment(int depId) 
        {
            Employees.Clear();
            foreach (Employee emp in _empRepo.GetEmployeesByDep(depId))
                Employees.Add(emp);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
