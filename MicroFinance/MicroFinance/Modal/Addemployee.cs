using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFinance.Modal
{
    class Addemployee:BindableBase
    {
        private const string Format = "dd-mm-yyyy";
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
                    try
                    {
                        if (validation.IsString(value))
                        {
                            _branchname = value;
                            RaisedPropertyChanged("BranchName");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
                    
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
                    try
                    {
                        if(validation.IsString(value))
                        {
                            _designation = value;
                            RaisedPropertyChanged("Designation");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
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
               if(value!=_employeename)
                {
                    try
                    {
                        if(validation.IsString(value))
                        {
                            _employeename = value;
                            RaisedPropertyChanged("EmployeeName");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
                }
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
                _age = CalculateAge(_dob);
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
                    try
                    {
                        if(validation.IsPhoneNumber(value))
                        {
                            _contactnumber = value;
                            RaisedPropertyChanged("ContactNumber");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
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
                    try
                    {
                        if(validation.IsEmail(value))
                        {
                            _email = value;
                            RaisedPropertyChanged("Email");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
                }
            }
        }
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
                    try
                    {
                        if(validation.IsAadhar(value))
                        {

                        }
                    }
                    catch
                    {

                    }
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
}
