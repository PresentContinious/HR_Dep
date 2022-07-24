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

namespace HR_Department.ViewModels
{
    public class DepartmentsViewModel : INotifyPropertyChanged
    {
        private DepartmentsRepo _depRepo;
        public ObservableCollection<Department> Departments { get; set; }

        private Department _selectedDepartment;
        public Department SelectedDepartment 
        {
            get { return _selectedDepartment; }
            set { _selectedDepartment = value; OnPropertyChanged("SelectedDepartment"); }
        }

        public DepartmentsViewModel() 
        {
            _depRepo = new DepartmentsRepo();
            Departments = new ObservableCollection<Department>();
            foreach (Department dep in _depRepo.GetAllDepartments())
                Departments.Add(dep);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
