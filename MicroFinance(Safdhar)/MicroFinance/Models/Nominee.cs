using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using MicroFinance.Validations;

namespace MicroFinance.Models
{
    public class Nominee:BindableBase
    {
        private string _nomineeName;
        public string NomineeName
        {
            get
            {
                return _nomineeName;
            }
            set
            {
                _nomineeName = value;
                RaisePropertyChanged("NomineeName");
            }
        }
        private DateTime _dateofBirth=DateTime.Today;
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
        private string _age;
        public string Age
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
        private string _relationship;
        public string RelationShip
        {
            get
            {
                return _relationship;
            }
            set
            {
                _relationship = value;
            }
        }
        private bool _isNomineeNull;
        public bool IsNomineeNull
        {
            get
            {
                return _isNomineeNull;
            }
            set
            {
                _isNomineeNull = value;
                RaisePropertyChanged("IsNomineeNull");
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
    }
}
