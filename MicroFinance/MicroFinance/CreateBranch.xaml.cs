using MicroFinance.Modal;
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

namespace MicroFinance
{
    /// <summary>
    /// Interaction logic for CreateBranch.xaml
    /// </summary>
    public partial class CreateBranch : Page
    {
        public List<string> Regionlist =new List<string>() {"Chennai", "Trichy", "Coimbatore", "Salem" };
        public List<string> Managerlist = new List<string>() { "Ashraf", "SAfdhar", "Thalif", "Santhosh" };
        public List<string> Accountantlist = new List<string>() { "Ashraf", "SAfdhar", "Thalif", "Santhosh" };
        Createbranch CB = new Createbranch();
        public CreateBranch()
        {
            InitializeComponent();
            MainGrid.DataContext = CB;
            RegionBox.ItemsSource = Regionlist;
            Managerbox.ItemsSource = Managerlist;
            Accountantbox.ItemsSource = Accountantlist;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BranchAccountdetailsPanel.IsOpen = true;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            BranchAccountdetailsPanel.IsOpen = false;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmPanel.IsOpen = true;
        }

        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmPanel.IsOpen = false;
        }

        private void PanelCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            BranchAccountdetailsPanel.IsOpen = false;
        }
    }
}
