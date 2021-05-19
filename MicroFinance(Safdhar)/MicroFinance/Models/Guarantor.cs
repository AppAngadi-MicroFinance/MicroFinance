using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFinance.Models
{
    class Guarantor
    {
        private string _guarantorName;
        public string GuarantorName
        {
            get
            {
                return _guarantorName;
            }
            set
            {
                _guarantorName = value;
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
        private bool _isGuarantorNull;
        public bool IsGuarantorNull
        {
            get
            {
                return _isGuarantorNull;
            }
            set
            {
                _isGuarantorNull = value;
            }
        }
    }
}
