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
            MainGrid.IsEnabled = false;
            MainGrid.Opacity = 0.4;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            BranchAccountdetailsPanel.IsOpen = false;
            MainGrid.Opacity = 1.0;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            if(IsemptyCheck()==true)
            {
                ConfirmPanel.IsOpen = true;
                MainGrid.Opacity = 0.4;
                MainGrid.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please Enter All the Required Fields", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmPanel.IsOpen = false;
            MainGrid.Opacity = 1.0;
            MainGrid.IsEnabled = true;
        }

        private void PanelCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            BranchAccountdetailsPanel.IsOpen = false;
            MainGrid.IsEnabled = true;
            MainGrid.Opacity = 1.0;
        }

        private void CreateBr_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CB.ToString());
        }
        public bool IsemptyCheck()
        {
            if(string.IsNullOrEmpty(RegionBox.Text)&& string.IsNullOrEmpty(BranchnameBox.Text)&& string.IsNullOrEmpty(AddressBox.Text)&& string.IsNullOrEmpty(LandlineBox.Text)&&double.Parse(LandlineBox.Text)==0&& string.IsNullOrEmpty(Managerbox.Text)&& string.IsNullOrEmpty(Accountantbox.Text))
            {
                return false;
            }
            return true;
        }
    }
}
