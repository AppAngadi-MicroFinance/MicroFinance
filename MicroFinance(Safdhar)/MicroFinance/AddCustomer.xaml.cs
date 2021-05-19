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
using MicroFinance.Models;

namespace MicroFinance
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Page
    {

        Customer customer = new Customer();
        Guarantor guarantor = new Guarantor();
        Nominee nominee = new Nominee();
        public AddCustomer()
        {
            InitializeComponent();
            IsEligible();

            CustomerGrid.DataContext = customer;
            AddressGrid.DataContext = customer;
            GurantorGrid.DataContext = guarantor;
            NomineeGrid.DataContext = nominee;
            //   SelectReligion.ItemsSource = cs.Religion;
        }
        void IsEligible()
        {
            if (MainWindow.LoginDesignation == "FO")
            {
                SelectBranch.IsEnabled = false;
                SelectFO.IsEnabled = false;
            }
            else if (MainWindow.LoginDesignation == "RM")
            {
                SelectBranch.IsEnabled = true;
                SelectFO.IsEnabled = true;
            }
            else
            {
                SelectBranch.IsEnabled = false;
                SelectFO.IsEnabled = false;
            }

        }

        private void AddPG_Click(object sender, RoutedEventArgs e)
        {
            // NavigationService.GetNavigationService(this).Navigate(new AddPg());
            AddPg APG = new AddPg();
            APG.ShowDialog();


        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void SaveCustomer_Click(object sender, RoutedEventArgs e)
        {
        }

        private void SelectReligion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CommunityBox.IsEnabled = true;
        }

        private void AddGaurantor_Click(object sender, RoutedEventArgs e)
        {
            AddGuarantorPopopup.IsOpen = true;
        }

        private void AddGuarantor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
