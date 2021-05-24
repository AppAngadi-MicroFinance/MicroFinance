using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MicroFinance.Modal
{
    class Addemployee:BindableBase
    {
        Validation validation = new Validation();
        private string _branchname;
        public string BranchName
        {
            get
            {
                return _branchname;
            }
            set
            {
                if(value!=_branchname)
                {
                   
                    _branchname = value;
                     RaisedPropertyChanged("BranchName");
                    
                }
            }
        }
        private string _designation;
        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                if(value!=_designation)
                {
                   
                   _designation = value;
                   RaisedPropertyChanged("Designation");
                  
                }
            }
        }
        private string _employeename;
        public string EmployeeName
        {
            get
            {
                return _employeename;
            }
            set
            {
               
               _employeename = value;
               RaisedPropertyChanged("EmployeeName");
               
            }
           
        }
        private DateTime _dob;
        public DateTime DOB
        {
            get
            {
                return _dob;
            }
            set
            {
                if(value!=_dob)
                {
                    _dob = value;
                    RaisedPropertyChanged("DOB");
                }
            }
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                RaisedPropertyChanged("Age");
            }
        }
        private string _contactnumber;
        public string ContactNumber
        {
            get
            {
                return _contactnumber;
            }
            set
            {
                if(value!=_contactnumber)
                {
                   
                   _contactnumber = value;
                   RaisedPropertyChanged("ContactNumber");
                }
            }
        }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if(value!=_email)
                {
                  _email = value;
                   RaisedPropertyChanged("Email");
                }
            }
        }

        //private Address _employeeAddress;
        //public Address EmployeeAddress
        //{
        //    get
        //    {
        //        return _employeeAddress;
        //    }
        //    set
        //    {
        //        _employeeAddress = value;
        //        RaisedPropertyChanged("EmployeeAddress");
        //    }
        //}






        //
        private string _houseno;
        public string HouseNo
        {
            get
            {
                return _houseno;
            }
            set
            {
                _houseno = value;
                RaisedPropertyChanged("HouseNo");
            }
        }
        private string _townname;
        public string TownName
        {
            get
            {
                return _townname;
            }
            set
            {
                _townname = value;
                RaisedPropertyChanged("TownName");
            }
        }
        private string _district;
        public string District
        {
            get
            {
                return _district;
            }
            set
            {
                _district = value;
                RaisedPropertyChanged("District");
            }
        }
        private string _pincode;
        public string Pincode
        {
            get
            {
                return _pincode;
            }
            set
            {
                _pincode = value;
                RaisedPropertyChanged("Pincode");
            }
        }
        //

        private string _aadharnumber;
        public string AadharNumber
        {
            get
            {
                return _aadharnumber;
            }
            set
            {
                if(value!=_aadharnumber)
                {
                    _aadharnumber = value;
                    RaisedPropertyChanged("Aadharnumber");
                }
            }
        }
        private string _religion;
        public string Religion
        {
            get
            {
                return _religion;
            }
            set
            {
                _religion = value;
                RaisedPropertyChanged("Religion");
            }
        }
        private string _education;
        public string Education
        {
            get
            {
                return _education;
            }
            set
            {
                _education = value;
                RaisedPropertyChanged("Education");
            }
        }
        private DateTime _dateofjoining;
        public DateTime DateOfJoining
        {
            get
            {
                return _dateofjoining.Date;
            }
            set
            {
                _dateofjoining = value;
                RaisedPropertyChanged("DateOfJoining");
            }
        }
        private string _addressproofName;
        public string AddressProofName
        {
            get
            {
                return _addressproofName;
            }
            set
            {
                _addressproofName = value;
                RaisedPropertyChanged("AddressProofName");
            }
        }
        private BitmapImage _addressproofimage;
        public BitmapImage AddressProofImage
        {
            get
            {
                return _addressproofimage;
            }
            set
            {
                _addressproofimage = value;
                RaisedPropertyChanged("AddressProofImage");
            }
        }

        private string _photoproofname;
        public string PhotoProofName
        {
            get
            {
                return _photoproofname;
            }
            set
            {
                _photoproofname = value;
                RaisedPropertyChanged("PhotoProofName");
            }
        }
        private BitmapImage _photoproofimage;
        public BitmapImage PhotoProofImage
        {
            get
            {
                return _photoproofimage;
            }
            set
            {
                _photoproofimage = value;
                RaisedPropertyChanged("PhotoProofImage");
            }
        }
        private BitmapImage _profileimage;
        public BitmapImage ProfileImage
        {
            get
            {
                return _profileimage;
            }
            set
            {
                _profileimage = value;
                RaisedPropertyChanged("ProfileImage");
            }
        }

        private string _accountholdername;
        public string AccountHolderName
        {
            get
            {
                return _accountholdername;
            }
            set
            {
                
               _accountholdername = value;
              RaisedPropertyChanged("AccountHolderName");
                 
            }
        }
        private string _accountnumber;
        public string AccountNumber
        {
            get
            {
                return _accountnumber;
            }
            set
            {
              _accountnumber = value;
              RaisedPropertyChanged("Account Number");
            }
        }
        private string _bankname;
        public string BankName
        {
            get
            {
                return _bankname;
            }
            set
            {
              _bankname = value;
              RaisedPropertyChanged("BankName");
            }
        }
        private string _bankbranchname;
        public string BankBranchName
        {
            get
            {
                return _bankbranchname;
            }
            set
            {
                _bankbranchname = value;
                RaisedPropertyChanged("BankBranchName"); 
            }
        }
        private string _ifsccode;
        public string IFSCCode
        {
            get
            {
                return _ifsccode;
            }
            set
            {
                if (value != _ifsccode)
                {
                    _ifsccode = value.ToUpper();
                    RaisedPropertyChanged("IFSCCODE");
                }
            }
        }
        private string _micrcode;
        public string MICRCode
        {
            get
            {
                return _micrcode;
            }
            set
            {
                if (value != _micrcode)
                {
                    _micrcode = value.ToUpper();
                    RaisedPropertyChanged("MICRCode");
                }
            }
        }

        
        
        
        public int CalculateAge(DateTime date)
        {
            int age = 0;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            age = year - date.Year;
            if(date.Month<month)
            {
                age -= 1;
            }
            return age;
        }
    }
    public class Address
    {
        public string HouseNo { get; set; }
        public string TownName { get; set; }
        public string District { get; set; }
        public string Pincode { get; set; }

        public override string ToString()
        {
            return string.Format("{0},\n{1},\n{2},\n{3}." + HouseNo, TownName, District, Pincode);
        }
    }
}
