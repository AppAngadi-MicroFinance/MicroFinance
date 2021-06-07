
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

        public static Customer customer = new Customer();
        public static Guarantor guarantor = new Guarantor();
        public static Nominee nominee = new Nominee();
        public static StaticProperty CaptureImageMessage = new StaticProperty();

        string WhichClassButtonClick;
        public AddCustomer()
        {
            InitializeComponent();
            IsEligible();

            BranchDetailsGrid.DataContext = customer;
            CustomerGrid.DataContext = customer;
            AddressGrid.DataContext = customer;
            AddressProofGrid.DataContext = customer;
            PhotoProofGrid.DataContext = customer;
            PhotoProfileGrid.DataContext = customer;

            GurantorGrid.DataContext = guarantor;
            GuarantorAddressDetails.DataContext = guarantor;
            GuarnatorDetails.DataContext = guarantor;

            NomineeGrid.DataContext = nominee;
            NomineeAddressDetails.DataContext = nominee;
            NomineeDetails.DataContext = nominee;
        }

        public static void StatusMessageWhileCapturingImage(int Type,string Message)
        {
            CaptureImageMessage.MessageType = Type;
            CaptureImageMessage.StatusMessage = Message;
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

        void EnableDisableBackground(bool Enable)
        {
            if(Enable)
            {
                BranchDetailsGrid.IsEnabled = true;
                CustomerGrid.IsEnabled = true;
                AddressGrid.IsEnabled = true;
                CustomerOtherDetails.IsEnabled = true;
            }
            else
            {
                BranchDetailsGrid.IsEnabled = false;
                CustomerGrid.IsEnabled = false;
                AddressGrid.IsEnabled = false;
                CustomerOtherDetails.IsEnabled = false;
            }
        }

        private void SelectReligion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CommunityBox.IsEnabled = true;
        }

        //add peer group
        private void AddPG_Click(object sender, RoutedEventArgs e)
        {
            // NavigationService.GetNavigationService(this).Navigate(new AddPg());
            AddPg APG = new AddPg();
            APG.ShowDialog();


        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        //save customer
        private void SaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            BranchManagerWindow BMNF = new BranchManagerWindow();
            BMNF.ShowDialog();
        }

        private void SelectSHG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(SelectSHG.SelectedIndex==0)
            {
                SelectPG.Items.Add("PG1");
                SelectPG.Items.Add("PG2");
                SelectPG.Items.Add("PG3");
                SelectPG.Items.Add("PG4");
                SelectPG.Items.Add("PG5");
            }
            else
            {
                SelectPG.Items.Add("PG1");
                SelectPG.Items.Add("PG2");
                SelectPG.Items.Add("PG3");
            }
        }

        private void ImageSavebtn_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage image = Capture.SavedImage;
            if(image!=null)
            {
                string txt = PhotoProofNametxt.Text;
                SetImage(image, txt);
                CaptureImage.Visibility = Visibility.Collapsed;
                Capture.SavedImage = null;
                //    MessageBox.Show("Photo Added Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                StatusMessageWhileCapturingImage(2, "Please Capture or Select Photo To Save....");
                //CaptureImageStatus.Text = "Please Capture or Select Photo";
            }
        }

        private void ImgCancelbtn_Click(object sender, RoutedEventArgs e)
        {
            CaptureImage.Visibility = Visibility.Collapsed;
        }

        void SetImage(BitmapImage image, string imagename)
        {

            if (WhichClassButtonClick.Equals("Customer"))
            {
                switch (imagename)
                {
                    case "Address Proof":
                        customer.AddressProof = image;
                        MainWindow.StatusMessageofPage(1, "Successfully Customer Address Proof Added...");
                        break;
                    case "Photo Proof":
                        customer.PhotoProof = image;
                        MainWindow.StatusMessageofPage(1, "Successfully Customer Photo Proof Added...");
                        break;
                    case "Profile Picture":
                        {
                            customer.ProfilePicture = image;
                            MainWindow.StatusMessageofPage(1, "Successfully Customer Profile Picture Added...");
                        }
                        break;
                }
            }
            else if (WhichClassButtonClick.Equals("Guarantor"))
            {
                switch (imagename)
                {
                    case "Address Proof":
                        guarantor.AddressProof = image;
                        //MainWindow.StatusMsg.MessageType = 1;
                        //MainWindow.StatusMsg.StatusMessage = "Successfully Guarantor Address Proof Added";
                        break;
                    case "Photo Proof":
                        guarantor.PhotoProof = image;
                        //MainWindow.StatusMsg.MessageType = 1;
                        //MainWindow.StatusMsg.StatusMessage = "Successfully Guarantor Photo Proof Added";
                        break;
                    case "Profile Picture":
                        guarantor.ProfilePicture = image;
                        //MainWindow.StatusMsg.MessageType = 1;
                        //MainWindow.StatusMsg.StatusMessage = "Successfully Guarantor Profile Picture Added";
                        break;
                }
            }
            else if (WhichClassButtonClick.Equals("Nominee"))
            {
                switch (imagename)
                {
                    case "Address Proof":
                        nominee.AddressProof = image;
                        //MainWindow.StatusMsg.MessageType = 1;
                        //MainWindow.StatusMsg.StatusMessage = "Successfully Nominee Address Proof Added";
                        break;
                    case "Photo Proof":
                        nominee.PhotoProof = image;
                        //MainWindow.StatusMsg.MessageType = 1;
                        //MainWindow.StatusMsg.StatusMessage = "Successfully Nominee Photo Proof Added";
                        break;
                    case "Profile Picture":
                        nominee.ProfilePicture = image;
                        //MainWindow.StatusMsg.MessageType = 1;
                        //MainWindow.StatusMsg.StatusMessage = "Successfully Nominee Profile Picture Added";
                        break;
                }
            }
        }

        private void ProfileImageOk_Click(object sender, RoutedEventArgs e)
        {
            ViewImagePopup.IsOpen = false;
        }

        //adding profile image 

        Capture CapturePhoto = new Capture();

        private void AddProfilePhoto_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Profile Picture";
            WhichClassButtonClick = "Customer";
            CaptureImage.Visibility = Visibility.Visible;
            CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void ViewProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Profile Picture";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = customer.ProfilePicture;
        }
        private void EditProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = customer.ProfilePicture;
            PhotoProofNametxt.Text = "Profile Picture";
            WhichClassButtonClick = "Customer";
            CaptureImage.Visibility = Visibility.Visible;
        }
        //adding Address Proof image

        Capture AddressProofPhoto = new Capture();

        private void AddAddressProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture(); 
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto); 
            PhotoProofNametxt.Text = "Address Proof";
            WhichClassButtonClick = "Customer";
            CaptureImage.Visibility = Visibility.Visible;
            CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void ViewAddressProof_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Address Proof";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = customer.AddressProof;
        }

        private void EditAddressProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = customer.AddressProof;
            PhotoProofNametxt.Text = "Address Proof";
            WhichClassButtonClick = "Customer";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        //Adding Photo Proof Image

        private void AddPhotoProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Photo Proof";
            WhichClassButtonClick = "Customer";
            CaptureImage.Visibility = Visibility.Visible;
            CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void ViewPhotoProof_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Photo Proof";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = customer.PhotoProof;
        }

        private void EditPhototProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = customer.PhotoProof;
            PhotoProofNametxt.Text = "Photo Proof";
            WhichClassButtonClick = "Customer";
            CaptureImage.Visibility = Visibility.Visible;
            CaptureImageStatus.DataContext = CaptureImageMessage;
        }



        //Guarantor 

        private void AddGaurantor_Click(object sender, RoutedEventArgs e)
        {
            GuarantorWindow.Visibility = Visibility.Visible;
            EnableDisableBackground(false);
        }

        private void ViewGaurantor_Click(object sender, RoutedEventArgs e)
        {
            ViewGuarantorPopopup.IsOpen = true;
            EnableDisableBackground(false);
            ViewGuarantorGrid.DataContext = guarantor;

        }

        private void UpdateGuarantor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditGaurantor_Click(object sender, RoutedEventArgs e)
        {
            GuarantorWindow.Visibility = Visibility.Visible;
            EnableDisableBackground(false);
        }

        private void SaveGuarantor_Click(object sender, RoutedEventArgs e)
        {
            GuarantorWindow.Visibility = Visibility.Collapsed;
            guarantor.IsGuarantorNull = true;
            EnableDisableBackground(true);
            MainWindow.StatusMessageofPage(1, "Successfully Guarantor Added...");
            if (guarantor.IsNominee)
            {
                nominee.NomineeName = guarantor.GuarantorName;
                nominee.DateofBirth = guarantor.DateofBirth;
                nominee.Age = guarantor.Age;
                nominee.ContactNumber = guarantor.ContactNumber;
                nominee.Occupation = guarantor.Occupation;
                nominee.RelationShip = guarantor.RelationShip;
                nominee.DoorNumber = guarantor.DoorNumber;
                nominee.StreetName = guarantor.StreetName;
                nominee.LocalityTown = guarantor.LocalityTown;
                nominee.Pincode = guarantor.Pincode;
                nominee.City = guarantor.City;
                nominee.State = guarantor.State;
                nominee.IsNomineeNull = true;
                nominee.AddressProof = guarantor.AddressProof;
                nominee.PhotoProof = guarantor.PhotoProof;
                nominee.ProfilePicture = guarantor.ProfilePicture;
                SameAsCustomerAddressForNominee.IsChecked = SameAsCustomerAddress.IsChecked;
                //if(SameAsCustomerAddress.IsChecked==true)
                //{
                //    nominee.DoorNumber = guarantor.DoorNumber;
                //    nominee.StreetName = guarantor.StreetName;
                //    nominee.LocalityTown = guarantor.LocalityTown;
                //    nominee.Pincode = guarantor.Pincode;
                //    nominee.City = guarantor.City;
                //    nominee.State = guarantor.City;
                //}
                MainWindow.StatusMessageofPage(1, "Successfully Guarantor and Nominee Added...");
            }
        }

        private void GuarantorAddAddressProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Address Proof";
            WhichClassButtonClick = "Guarantor";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void ViewAddressProofOfGuarantor_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Address Proof";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = guarantor.AddressProof;
        }

        private void EditAddressProofofGuarantor_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = guarantor.AddressProof;
            PhotoProofNametxt.Text = "Address Proof";
            WhichClassButtonClick = "Guarantor";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void GuarantorAddPhotoProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Photo Proof";
            WhichClassButtonClick = "Guarantor";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void GuarantorViewPhotoProof_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Photo Proof";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = guarantor.PhotoProof;
        }

        private void GuarantorEditPhototProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = guarantor.PhotoProof;
            PhotoProofNametxt.Text = "Photo Proof";
            WhichClassButtonClick = "Guarantor";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void GuarantorAddProfilePhoto_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Profile Picture";
            WhichClassButtonClick = "Guarantor";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void GuarantorViewProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Profile Picture";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = guarantor.ProfilePicture;
        }

        private void GuarantorEditProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = guarantor.ProfilePicture;
            PhotoProofNametxt.Text = "Profile Picture";
            WhichClassButtonClick = "Guarantor";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }



        //Nominee Details

        private void AddNominee_Click(object sender, RoutedEventArgs e)
        {
            AddNomineepopup.Visibility = Visibility.Visible;
            EnableDisableBackground(false);

        }

        private void ViewNominee_Click(object sender, RoutedEventArgs e)
        {
            ViewNomineePopopup.IsOpen = true;
            EnableDisableBackground(false);
            ViewNomineeDetails.DataContext = nominee;
            ViewNomineeAddress.DataContext = nominee;
        }

        private void EditNominee_Click(object sender, RoutedEventArgs e)
        {
            AddNomineepopup.Visibility = Visibility.Visible;
            EnableDisableBackground(false);
        }

        private void NomineeSaveGuarantor_Click(object sender, RoutedEventArgs e)
        {
            AddNomineepopup.Visibility = Visibility.Collapsed;
            EnableDisableBackground(true);
            nominee.IsNomineeNull = true;
            MainWindow.StatusMessageofPage(1, "Successfully Nominee Added...");
        }

        private void NomineeCancel_Click(object sender, RoutedEventArgs e)
        {
            AddNomineepopup.Visibility = Visibility.Collapsed;
            EnableDisableBackground(true);
        }

        private void NomineeAddAddressProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Address Proof";
            WhichClassButtonClick = "Nominee";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void NomineeViewAddressProof_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Address Proof";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = nominee.AddressProof;
        }

        private void NomineeEditAddressProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = nominee.AddressProof;
            PhotoProofNametxt.Text = "Address Proof";
            WhichClassButtonClick = "Nominee";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void NomineeAddPhotoProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Photo Proof";
            WhichClassButtonClick = "Nominee";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void NomineeViewPhotoProof_Click(object sender, RoutedEventArgs e)
        {
            ImageTitle.Text = "Photo Proof";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = nominee.PhotoProof;
        }

        private void NomineeEditPhototProof_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = nominee.PhotoProof;
            PhotoProofNametxt.Text = "Photo Proof";
            WhichClassButtonClick = "Nominee";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void NomineeAddProfilePhoto_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            CapturePhoto = new Capture();
            ImageSavebtn.Content = "Save";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            PhotoProofNametxt.Text = "Profile Picture";
            WhichClassButtonClick = "Nominee";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void NomineeViewProfilePicture_Click(object sender, RoutedEventArgs e)
        {

            ImageTitle.Text = "Profile Picture";
            ViewImagePopup.IsOpen = true;
            viewImage.Source = nominee.ProfilePicture;
        }

        private void NomineeEditProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            CaptureImageMessage = new StaticProperty();
            ImageSavebtn.Content = "Update";
            Captureframe.NavigationService.Navigate(CapturePhoto);
            CapturePhoto.CapImg.Source = nominee.ProfilePicture;
            PhotoProofNametxt.Text = "Profile Picture";
            WhichClassButtonClick = "Nominee";
            CaptureImage.Visibility = Visibility.Visible; CaptureImageStatus.DataContext = CaptureImageMessage;
        }

        private void ViewGuarantorOk_Click(object sender, RoutedEventArgs e)
        {
            ViewGuarantorPopopup.IsOpen = false;
            EnableDisableBackground(true);
        }

        private void ViewNomineeok_Click(object sender, RoutedEventArgs e)
        {
            ViewNomineePopopup.IsOpen = false;
            EnableDisableBackground(true);
        }

        private void SameAsCustomerAddress_Click(object sender, RoutedEventArgs e)
        {
            if(SameAsCustomerAddress.IsChecked==true)
            {
                GuarantorAddressDetails.IsEnabled = false;

                GuarantorHouseNOBox.Text = customer.DoorNumber;
                GuarantorStreetNameBox.Text = customer.StreetName;
                GuarantorLocalityBox.Text = customer.LocalityTown;
                GuarantorPincodeBox.Text = customer.Pincode.ToString();
                GuarantorCityBox.Text = customer.City;
                GuarantorStateBox.Text = customer.State;
            }
            else
            {
                GuarantorAddressDetails.IsEnabled = true;

                GuarantorHouseNOBox.Text = "";
                GuarantorStreetNameBox.Text = "";
                GuarantorLocalityBox.Text = "";
                GuarantorPincodeBox.Text = "";
                GuarantorCityBox.Text = "";
                GuarantorStateBox.Text = "";
            }
        }

        private void SameAsCustomerAddressForNominee_Checked(object sender, RoutedEventArgs e)
        {
            NomineeAddressDetails.IsEnabled = false;

            NomineeHouseNOBox.Text = customer.DoorNumber;
            NomineeStreetNameBox.Text = customer.StreetName;
            NomineeLocalityBox.Text = customer.LocalityTown;
            NomineePincodeBox.Text = customer.Pincode.ToString();
            NomineeCityBox.Text = customer.City;
            NomineeStateBox.Text = customer.State;
        }

        private void SameAsCustomerAddressForNominee_Unchecked(object sender, RoutedEventArgs e)
        {
            NomineeAddressDetails.IsEnabled = true;

            NomineeHouseNOBox.Text = "";
            NomineeStreetNameBox.Text = "";
            NomineeLocalityBox.Text = "";
            NomineePincodeBox.Text = "";
            NomineeCityBox.Text = "";
            NomineeStateBox.Text = "";
        }
    }
}
