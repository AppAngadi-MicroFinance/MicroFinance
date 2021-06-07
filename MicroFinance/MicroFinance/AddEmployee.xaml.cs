using MicroFinance.Modal;
using Microsoft.Win32;
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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Page
    {
        public List<string> ProofTypes = new List<string> { "Aadhar Proof", "Family Card", "Licence", "VoterID" };
        public List<string> DesignationList = new List<string> { "Manager", "Region Manager","Accountant","Field Officer"};
        public List<string> BranchList;
        public List<string> Religionlist = new List<string> { "Muslim", "Hindu", "Christianity" };
        Employee addemployee = new Employee();
        StringBuilder RequiredFields = new StringBuilder();
        StringBuilder Emptyfields = new StringBuilder();
        public AddEmployee(Employee emp)
        {
            InitializeComponent();
            EmployeeMainGrid.DataContext = emp;
            addemployee = emp;
            EmployeeSaveBtn.Content = "Update";
            AddressProofcombo.ItemsSource = ProofTypes;
            PhotoproofCombo.ItemsSource = ProofTypes;
            BranchCombo.ItemsSource = addemployee.BranchList;
            DesignationCombo.ItemsSource = DesignationList;
            Religioncombo.ItemsSource = Religionlist;
            capturepanel.Visibility = Visibility.Collapsed;
            Captureframe.NavigationService.Navigate(new Capture());
        }
        public AddEmployee()
        {
            InitializeComponent();
            addemployee = new Employee();
            EmployeeMainGrid.DataContext = addemployee;
            capturepanel.Visibility = Visibility.Collapsed;
            Captureframe.NavigationService.Navigate(new Capture());
            AddressProofcombo.ItemsSource = ProofTypes;
            PhotoproofCombo.ItemsSource = ProofTypes;
            BranchCombo.ItemsSource = addemployee.BranchList;
            DesignationCombo.ItemsSource = DesignationList;
            Religioncombo.ItemsSource = Religionlist;
        }

        private void BankDetails_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAccountdetailsPanel.IsOpen = true;
            EmployeeMainGrid.IsEnabled = false;

        }

        private void PanelCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAccountdetailsPanel.IsOpen = false;
            EmployeeMainGrid.IsEnabled = true;
        }

        private void AddressproofBtn_Click(object sender, RoutedEventArgs e)
        { 
            //Captureframe.NavigationService.Navigate(new Capture());
            
            PhotoProofNametxt.Text = "Address Proof";
            capturepanel.Visibility = Visibility.Visible;
            EmployeeDetailsGrid.IsEnabled = false;
            capturepanel.IsEnabled = true;
        }

        private void SampleCheck_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            MessageBox.Show(sb.ToString());
           
        }

        private void ImageSavebtn_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage image = Capture.SavedImage;
            string txt = PhotoProofNametxt.Text;
            SetImage(image, txt);
            capturepanel.Visibility = Visibility.Collapsed;
            EmployeeDetailsGrid.IsEnabled = true;
        }

        private void CaptureModelCloseButton_Click(object sender, RoutedEventArgs e)
        {
            capturepanel.IsEnabled = false;
            capturepanel.Visibility = Visibility.Collapsed;
            EmployeeDetailsGrid.IsEnabled = true;
        }

        public void SetImage(BitmapImage image,string imagename)
        {
            switch(imagename)
            {
                case "Address Proof":
                    addemployee.AddressProofImage = image;
                    addemployee.IsAddressProof = true;
                    MainWindow.StatusMessageofPage(0, "Address Proof Added");
                    break;
                case "Photo Proof":
                    addemployee.PhotoProofImage = image;
                    addemployee.IsPhotoProof = true;
                    MainWindow.StatusMessageofPage(0, "Photo Proof Added");
                    break;
                case "Profile Picture":
                    addemployee.ProfileImage = image;
                    addemployee.IsProfilePicture = true;
                    MainWindow.StatusMessageofPage(0, "Profile Picture Added");
                    break;
            }
        }

        private void PhotoProofBtn_Click(object sender, RoutedEventArgs e)
        {
            Captureframe.NavigationService.Navigate(new Capture());
            PhotoProofNametxt.Text = "Photo Proof";
            capturepanel.Visibility = Visibility.Visible;
            EmployeeDetailsGrid.IsEnabled = false;
            capturepanel.IsEnabled = true;

        }

        private void ProfilePictureBtn_Click(object sender, RoutedEventArgs e)
        {
            Captureframe.NavigationService.Navigate(new Capture());
            PhotoProofNametxt.Text = "Profile Picture";
            capturepanel.Visibility = Visibility.Visible;
            EmployeeDetailsGrid.IsEnabled = false;
            capturepanel.IsEnabled = true;

        }

        private void EmployeeSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            IsemptyCheck();
            if (RequiredFields.Length == 0)
            {
                if (Emptyfields.Length == 0)
                {
                    ConfirmationPanel.IsOpen = true;
                    EmployeeMainGrid.IsEnabled = false;
                }
                else
                {
                    if (MessageBox.Show("Check These fields are Empty\n" + Emptyfields.ToString() + "Are you sure You want to create Branch Without These Information", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
                    {
                        ConfirmationPanel.IsOpen = true;
                        EmployeeMainGrid.IsEnabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("These Fields are Mandatory Please Fill All these Fields\n" + RequiredFields.ToString(), "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void BankDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            proofDetailsBtn.IsEnabled = false;
            BankDetailsPanel.IsOpen = true;
        }

        private void proofDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmationPanel.IsEnabled = false;
            ProofDetailsPanel.IsOpen = true;
        }

        private void bankdetailspanelclosebtn_Click(object sender, RoutedEventArgs e)
        {
            BankDetailsPanel.IsOpen = false;
            ConfirmationPanel.IsEnabled = true;
        }

        private void ProofDetailscloseBtn_Click(object sender, RoutedEventArgs e)
        {
            ProofDetailsPanel.IsOpen = false;
            ConfirmationPanel.IsEnabled = true;
        }
        private void ConfirmationPanelCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmationPanel.IsOpen = false;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMainGrid.DataContext = new Employee();
        }

        private void EmpAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConfirmationPanel.IsOpen = false;
                EmployeeMainGrid.IsEnabled = true;
                addemployee.EmployeeAdd();
                if(EmployeeSaveBtn.Content.ToString()=="Save")
                {
                    MainWindow.StatusMessageofPage(0, "Employee Added Successfully");
                }
                else if(EmployeeSaveBtn.Content.ToString()=="Update")
                {
                    MainWindow.StatusMessageofPage(0, "Employee Updated Successfully");
                }
                this.NavigationService.Navigate(new AddEmployee());
            }
            catch (Exception ex)
            {
                MainWindow.StatusMessageofPage(1, ex.Message);
            }
        }
        public void IsemptyCheck()
        {
            RequiredFields = new StringBuilder();
            Emptyfields = new StringBuilder();
            if (BranchCombo.Text == "")
            {
                RequiredFields.Append("Branch Name*\n");
            }
            if (DesignationCombo.Text == "")
            {
                RequiredFields.Append("Designation*\n");
            }
            if (Employeenamebox.Text == "")
            {
                RequiredFields.Append("Employee Name*\n");
            }
            if (Employeedob.Text == ""||Employeedob.Text==DateTime.Now.ToString("dd/MM/yyyy"))
            {
                RequiredFields.Append("Employee DOB*\n");
            }
            if (Employeeage.Text == ""|| Employeeage.Text=="0")
            {
                RequiredFields.Append("Employee Age*\n");
            }
            if (EmployeeContactnumber.Text == "")
            {
                RequiredFields.Append("Employee Number*\n");
            }
            if (EmployeeEmail.Text == "")
            {
                RequiredFields.Append("Employee Email*\n");
            }
            if (EmployeeAadhar.Text == "")
            {
                RequiredFields.Append("Employee Aadhar*\n");
            }
            if (EmployeeEducation.Text == "")
            {
                RequiredFields.Append("Employee Education*\n");
            }
            if (Employeejoiningdate.Text == "")
            {
                RequiredFields.Append("Date of Joining*\n");
            }
            if (houseno.Text == "")
            {
                Emptyfields.Append("HouseNo\n");
            }
            if (townname.Text == "")
            {
                Emptyfields.Append("Town Name\n");
            }
            if (district.Text == "")
            {
                Emptyfields.Append("District\n");
            }
            if (pincode.Text == "")
            {
                Emptyfields.Append("Pincode\n");
            }
            if (AddressProofcombo.Text == "")
            {
                RequiredFields.Append("Address Proof*\n");
            }
            if (PhotoproofCombo.Text == "")
            {
                RequiredFields.Append("Photo Proof*\n");
            }
            if (accountholdername.Text == "")
            {
                Emptyfields.Append("Accout Holder Name\n");
            }
            if (accountnumber.Text == "")
            {
                Emptyfields.Append("Account Number\n");
            }
            if (bankname.Text == "")
            {
                Emptyfields.Append("Bank Name\n");
            }
            if (bankbranchname.Text == "")
            {
                Emptyfields.Append("Bank Branch Name\n");
            }
            if (ifsccode.Text == "")
            {
                Emptyfields.Append("IFSC Code\n");
            }
            if (micrcode.Text == "")
            {
                Emptyfields.Append("MICR Code\n");
            }
        }

        
    }
}
