using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HR_Department.ViewModels;

namespace HR_Department.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AppViewModel _avm;

        public MainWindow()
        {
            InitializeComponent();
            _avm = new AppViewModel();
            this.DataContext = _avm;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int N = depList.Items.Count;
            if (N > 0) 
            {
                depList.SelectedIndex = 0;
                int K = empList.Items.Count;
                if (K > 0) 
                {
                    empList.SelectedIndex = 0;
                }
            }
        }

        private void depList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int depId = _avm.DepVm.SelectedDepartment.Id;
            _avm.EmpVm.LoadEmployeesByDepartment(depId);
        }
    }
}
