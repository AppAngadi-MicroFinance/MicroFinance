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
        public List<string> BranchList = new List<string> { "KK Nagar", "Anna Nagar", "Subramaniyapuram", "Karumandabam" };
        public List<string> Religionlist = new List<string> { "Muslim", "Hindu", "Christianity" };

        Addemployee addemployee = new Addemployee();
        Address address = new Address();
        public AddEmployee()
        {
            InitializeComponent();
            EmployeeMainGrid.DataContext = addemployee;
            capturepanel.Visibility = Visibility.Collapsed;
            Captureframe.NavigationService.Navigate(new Capture());
            AddressProofcombo.ItemsSource = ProofTypes;
            PhotoproofCombo.ItemsSource = ProofTypes;
            BranchCombo.ItemsSource = BranchList;
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
           
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp|All Files(*.*) |*.*";
            openFileDlg.Title = "Choose Image";
            openFileDlg.InitialDirectory = @"C:\";
            Panel.SetZIndex(EmployeeAccountdetailsPanel, -5);
            Nullable<bool> result = openFileDlg.ShowDialog();
           
            if (result == true)
            {

            }
        }

        private void ImageSavebtn_Click(object sender, RoutedEventArgs e)
        {
            
            BitmapImage image = Capture.SavedImage;
            string txt = PhotoProofNametxt.Text;
            SetImage(image, txt);
            capturepanel.Visibility = Visibility.Collapsed;
            EmployeeDetailsGrid.IsEnabled = true;
           MessageBox.Show("Photo Added Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
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
                    break;
                case "Photo Proof":
                    addemployee.PhotoProofImage = image;
                    break;
                case "Profile Picture":
                    addemployee.ProfileImage = image;
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
            ConfirmationPanel.IsOpen = true;


        }

        private void BankDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            BankDetailsPanel.IsOpen = true;
        }

        private void proofDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            ProofDetailsPanel.IsOpen = true;
        }

        private void bankdetailspanelclosebtn_Click(object sender, RoutedEventArgs e)
        {
            BankDetailsPanel.IsOpen = false;
        }

        private void ProofDetailscloseBtn_Click(object sender, RoutedEventArgs e)
        {
            ProofDetailsPanel.IsOpen = false;
        }

        private void ConfirmationPanelCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmationPanel.IsOpen = false;
        }
    }
}
