using MicroFinance.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFinance.Models
{
    class Customer : BindableBase
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
        private DateTime _dateofBirth;
        public DateTime DateofBirth
        {
            get
            {
                return _dateofBirth;
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
        private string _monthlyIncome;
        public string MonthlyIncome
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
