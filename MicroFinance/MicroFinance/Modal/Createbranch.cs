using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFinance.Modal
{
    class Createbranch:BindableBase
    {
        public Createbranch()
        {
           
        }
        private string _regionName;
        public string RegionName
        {
            get
            {
                return _regionName;
            }
            set
            {
                if (value != _regionName)
                {
                   try
                    {
                        if(IsString(value)==value)
                        {
                            _regionName = value;
                            RaisedPropertyChanged("RegionName");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
                }
                  
            }
        }
        private string _branchname;
        public string BranchName
        {
            get
            {
                return _branchname;
            }
            set
            {
                if (value != _regionName)
                {
                    try
                    {
                        if(IsString(value)==value)
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
        private string _branchaddress;
        public string BranchAddress
        {
            get
            {
                return _branchaddress;
            }
            set
            {
                _branchaddress = value;
                RaisedPropertyChanged("BranchAddress");
            }
        }
        private string _landlinenumber;
        public string LandlineNumber
        {
            get
            {
                return _landlinenumber;
            }
            set
            {
              
               
                    if(IsLandline(value)==true)
                    {
                        if(value.Length<=12)
                        {
                            _landlinenumber = value;
                            RaisedPropertyChanged("LandlineNumber");
                        }
                        else
                        {
                            throw new ArgumentException("Enter Correct Landline Number");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid LandLine Number");
                    }
            }

            
        }
        int _costpermonth;
        public int CostPerMonth
        {
            get
            {
                return _costpermonth;
            }
            set
            {
               //try
               // {
               //     if(IsAmount(value.ToString())==value)
               //     {
                        _costpermonth = value;
                        RaisedPropertyChanged("CostPerMonth");
               //     }
               // }
               // catch (Exception ex)
               // {
               //     throw new ArgumentException(ex.Message);
               // }
            } 
        }
        private string _managername;
        public string ManagerName
        {
            get
            {
                return _managername;
            }
            set
            {
                if(value!=_managername)
                {
                    _managername = value;
                    RaisedPropertyChanged("ManagerName");
                }
            }
        }
        private string _accoutantname;
        public string AccountantName
        {
            get
            {
                return _accoutantname;
            }
            set
            {
                _accoutantname = value;
                RaisedPropertyChanged("AccountantName");
            }
        }
        public DateTime OpeningDate { get; set; }
        private string _ebconnectionname;
        public string EBConnectionName
        {
            get
            {
                return _ebconnectionname;
            }
            set
            {
                try
                {
                    if(IsString(value)==value)
                    {
                        _ebconnectionname = value;
                        RaisedPropertyChanged("EbConnectionName");
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
        }
        private string _ebconnectionnubmer;
        public string EBConnectionNumber
        {
            get
            {
                return _ebconnectionnubmer;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                   
                        try
                        {
                            if(IsEBNumber(value)==value)
                            {
                                _ebconnectionnubmer = value;
                                RaisedPropertyChanged("EBConnectionNumber");
                            }

                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException(ex.Message);
                        }
                        
                }
            }
        }
        public string InternetConnectionName { get; set; }
        private int _internetconnectioncost;
        public int InternetConnectionCost
        {
            get
            {
                return _internetconnectioncost;
            }
            set
            {
                    if (value != _internetconnectioncost)
                    {
                        try
                        {
                            IsAmount(value.ToString());
                            _internetconnectioncost = value;
                            RaisedPropertyChanged("InternetConnectionCost");
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("Invalid Amount");
                        }
                        
                    }
               
            }
        }
        public string OwnerName { get; set; }
        private string _ownercontactnumber;
        public string OwnerContactNumber
        {
            get
            {
                return _ownercontactnumber;
            }
            set
            {

               if(value!=OwnerContactNumber)
                {
                    try
                    {
                        if(IsPhoneNumber(value)==value)
                        {
                            _ownercontactnumber = value;
                            RaisedPropertyChanged("OwnerContactNumber");
                        }    
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
                }

            }
        }
        public string OwnerAddress { get; set; }
        private int _advancepaid;
        public int AdvancePaid
        {
            get
            {
                return _advancepaid;
            }
            set
            {
                if(value!=_advancepaid)
                {
                   
                    _advancepaid = value;
                    RaisedPropertyChanged("AdvancePaid");
                }
            }
        }
        private int _rentpermonth;
        public int RentPerMonth
        {
            get
            {
                return _rentpermonth;
            }
            set
            {
                try
                {
                    IsAmount(value.ToString());
                    _rentpermonth = value;
                    RaisedPropertyChanged("RentPerMonth");
                }
                catch
                {
                    throw new Exception("Invalid Amount");
                }

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
                try
                {
                    if(IsString(value)==value)
                    {
                        _accountholdername = value;
                        RaisedPropertyChanged("AccountHolderName");
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
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
                if(value!=_accountnumber)
                {
                    try
                    {
                        if(IsAccountNumber(value)==value)
                        {
                            _accountnumber = value;
                            RaisedPropertyChanged("Account Number");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException(ex.Message);
                    }
                }
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
                try
                {
                    if (IsString(value) == value)
                    {
                        _bankname = value;
                        RaisedPropertyChanged("BankName");
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
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
                try
                {
                    if (IsString(value) == value)
                    {
                        _bankbranchname = value;
                        RaisedPropertyChanged("BankBranchName");
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
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
                if(value!=_ifsccode)
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
        public int IsAmount(string value)
        {
            int a;
            bool result = int.TryParse(value, out a);
            if(result!=true)
            {
                throw new ArgumentException("Invalid Amount");
            }
            return a;
            
        }
        public bool IsLandline(string value)
        {
            double v;
            bool result = double.TryParse(value, out v);
            if(result==true)
            {
                return true;
            }
            return false;
        }

        public string IsString(string value)
        {
           for(int i=0;i<value.Length;i++)
            {
                if(char.IsDigit(value[i])==true)
                {
                    throw new ArgumentException("Numbers Not Allowed");
                }
            }
            return value;
        }

        public string IsEBNumber(string value)
        {
            for(int i=0;i<value.Length;i++)
            {
                if(char.IsDigit(value[i])==false)
                {
                    throw new ArgumentException("The Eb Number is Invalid");
                }
            }
            string temp = value;
                if(temp.Length<=12)
                {
                if (temp.Length != 12)
                {
                    throw new ArgumentException("The Eb Number is Invalid,Number Must Be 12 Digit");
                }
                }
                else
                {
                    throw new ArgumentException("EB Number is Too Long");
                }
            
            return value;

        }
        public string IsAadhar(string value)
        {
            string AadharNumber;
            double a;
            bool res = double.TryParse(value, out a);
            if (res == true)
            {
                string temp = a.ToString();
                if (temp.Length <= 12)
                {
                    if (temp.Length == 12)
                    {
                        AadharNumber = a.ToString();
                    }
                    else
                    {
                        throw new ArgumentException("Aadhar Number Must Be 12 Digit");
                    }

                }
                else
                {
                    throw new ArgumentException("Aadhar Number is Too Long");
                }
            }
            else
            {
                throw new ArgumentException("Aadhar Number is Invalid");
            }
            return AadharNumber;

        }

        public string IsAccountNumber(string value)
        {
            string AccNumber;
            double a;
            bool res = double.TryParse(value, out a);
            if (res == true)
            {
                string temp = a.ToString();
                if (temp.Length <= 15)
                {
                   
                        AccNumber = a.ToString();
                }
                else
                {
                    throw new ArgumentException("Account Number is Invalid,Account Number length must be Less than or Equal to 15");
                }
            }
            else
            {
                throw new ArgumentException("Account Number is Invalid");
            }
            return AccNumber;

        }
        public string IsPhoneNumber(string value)
        {
            string Phnumber;
            bool res;
            double number;
            res = double.TryParse(value, out number);

            if (res == true)
            {
                double digit = Math.Floor(Math.Log10(number) + 1);
                if (digit <= 10)
                {
                    if(digit==10)
                    {
                        Phnumber = number.ToString();
                    }
                    else
                    {
                        throw new ArgumentException("Phone Number is Invalid,Phone Number Must be 10 digit");
                    }
                   
                }
                else
                {
                    throw new ArgumentException("The PhoneNumber is Too Long");
                }

            }
            else
            {
                throw new ArgumentException("Phone Number is Invalid");
            }
            return Phnumber;
        }
    }
}
