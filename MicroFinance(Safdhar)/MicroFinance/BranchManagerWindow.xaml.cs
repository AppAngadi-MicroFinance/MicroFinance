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
using System.Windows.Shapes;
using MicroFinance.Models;

namespace MicroFinance
{
    /// <summary>
    /// Interaction logic for BranchManagerWindow.xaml
    /// </summary>
    public partial class BranchManagerWindow : Window
    {
        public BranchManagerWindow()
        {
            InitializeComponent();
            Notification NTF = new Notification();
            NTF.NotificationFrom = MainWindow.LoginDesignation;
            NTF.NotificationPurpose = "Verifiy Customer To Add";
            NTF.OfficerName =AddCustomer.customer.FieldOfficer;
            NTF.BranchName = AddCustomer.customer.BranchName;
            NTF.NotificationDate = DateTime.Today.ToShortDateString();
            NTF.CustomerObj = AddCustomer.customer;
            NTF.GuarantorObj = AddCustomer.guarantor;
            NTF.NomineeObj = AddCustomer.nominee;
            BranchManagerNotifyPanel BMNF = new BranchManagerNotifyPanel(NTF);
            frame.Navigate(BMNF, UriKind.Relative);
        }
    }
}
