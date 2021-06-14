using MicroFinance.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MicroFinance.Models
{
    public class Customer : BindableBase
    {
        private bool _check;
        public bool Check
        {
            get
            {
                return _check;
            }
            set
            {
                _check = false;
            }
        }

        private string _branchName;
        public string BranchName
        {
            get
            {
                return _branchName;
            }
            set
            {
                _branchName = value;
            }
        }

        private string _fieldOfficer;
        public string FieldOfficer
        {
            get
            {
                return _fieldOfficer;
            }
            set
            {
                _fieldOfficer = value;
            }
        }

        private string _shg;
        public string SHG
        {
            get
            {
                return _shg;
            }
            set
            {
                _shg = value;
            }
        }

        private string _peerGroup;
        public string PeerGroup
        {
            get
            {
                return _peerGroup;
            }
            set
            {
                _peerGroup = value;
            }
        }

        private string _customerName;
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }
        }
        private DateTime _dateofBirth=DateTime.Now;
        public DateTime DateofBirth
        {
            get
            {
                return  _dateofBirth;
            }
            set
            {
                _dateofBirth = value;
                RaisePropertyChanged("DateofBirth");
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
            }
        }
        private string _contactNumber;
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
                RaisePropertyChanged("ContactBox");
            }
        }
        
        private string _community;
        public string Community
        {
            get
            {
                return _community;
            }
            set
            {
                _community = value;
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
            }
        }
        private int _familymembers;
        public int FamilyMembers
        {
            get
            {
                return _familymembers;
            }
            set
            {
                _familymembers = value;
            }
        }
        private int _earningmembers;
        public int EarningMembers
        {
            get
            {
                return _earningmembers;
            }
            set
            {
                _earningmembers = value;
            }
        }
        private string _occupation;
        public string Occupation
        {
            get
            {
                return _occupation;
            }
            set
            {
                _occupation = value;
            }
        }
        private int _monthlyIncome;
        public int MonthlyIncome
        {
            get
            {
                return _monthlyIncome;
            }
            set
            {
                _monthlyIncome = value;
            }
        }
        private string _doorNumber;
        public string DoorNumber
        {
            get
            {
                return _doorNumber;
            }
            set
            {
                _doorNumber = value;
            }
        }
        private string _streetName;
        public string StreetName
        {
            get
            {
                return _streetName;
            }
            set
            {
                _streetName = value;
            }
        }
        private string _localityTown;
        public string LocalityTown
        {
            get
            {
                return _localityTown;
            }
            set
            {
                _localityTown = value;
            }
        }
        private int _pincode;
        public int Pincode
        {
            get
            {
                return _pincode;
            }
            set
            {
                _pincode = value;
            }
        }
        
        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        private string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        private string _housingType;
        public string HousingType
        {
            get
            {
                return _housingType;
            }
            set
            {
                _housingType = value;
            }
        }
        private string _housingIndex;
        public string HousingIndex
        {
            get
            {
                return _housingIndex;
            }
            set
            {
                _housingIndex = value;
            }
        }
        private bool _isLeader;
        public bool IsLeader
        {
            get
            {
                return _isLeader;
            }
            set
            {
                _isLeader = value;
            }

        }
        private List<string> _religionlist=new List<string>();
        public List<string> Religionlist
        {
            get
            {
                return _religionlist;
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
            }
        }
        private BitmapImage _addressProof;
        public BitmapImage AddressProof
        {
            get
            {
                return _addressProof;
            }
            set
            {
                _addressProof = value;
                RaisePropertyChanged("AddressProof");
            }
        }
        private BitmapImage _photoProof;
        public BitmapImage PhotoProof
        {
            get
            {
                return _photoProof;
            }
            set
            {
                _photoProof = value;
                RaisePropertyChanged("PhotoProof");
            }
        }
        private BitmapImage _profilePicture;
        public BitmapImage ProfilePicture
        {
            get
            {
                return _profilePicture;
            }
            set
            {
                _profilePicture = value;
                RaisePropertyChanged("ProfilePicture");
            }
        }
        public Customer()
        {
            AddReligion();
        }
        private void AddReligion()
        {
            _religionlist.Add("Hindu");
            _religionlist.Add("Muslim");
        }
    }
}
