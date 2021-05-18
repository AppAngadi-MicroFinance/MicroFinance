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
                _regionName = value;
                RaisedPropertyChanged("RegionName");
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
                _branchname = value;
                RaisedPropertyChanged("BranchName");
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
                int a;
                bool res = int.TryParse(value.ToString(), out a);
                if (res == true)
                {
                    if (value != _costpermonth)
                    {
                        _costpermonth = a;
                        RaisedPropertyChanged("CostPerMonth");
                    }
                    else
                    {
                        throw new ArgumentException("Enter Valid Amount Eg: 2500");
                    }
                }
                else
                {
                    throw new ArgumentException("Amount is Invalid");
                }
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
        public string EBConnectionName { get; set; }
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
                    if (value != _ebconnectionnubmer)
                    {
                        bool res;
                        double number;
                        res = double.TryParse(value, out number);
                        if (res == true)
                        {
                            double digit = Math.Floor(Math.Log10(number) + 1);
                            if (digit <= 12)
                            {
                                _ebconnectionnubmer = number.ToString();
                                RaisedPropertyChanged("EBConnectionNumber");
                            }
                            else
                            {
                                throw new ArgumentException("The EbNumber is Too Long");
                            }

                        }
                        else
                        {
                            throw new ArgumentException("Eb Number is Invalid");
                        }
                    }
                }
            }
        }
        public string InternetConnectionName { get; set; }
        private int _internetconnectioncost;
        public string InternetConnectionCost
        {
            get
            {
                return _internetconnectioncost.ToString();
            }
            set
            {
                if (string.IsNullOrEmpty(_internetconnectioncost.ToString())==false)
                {
                    if (value != _internetconnectioncost.ToString())
                    {
                        if(IsAmount(value)==true)
                        {
                            _internetconnectioncost =int.Parse(value);
                            RaisedPropertyChanged("InternetConnectionCost");
                        }
                        else
                        {
                            throw new ArgumentException("Invalid Amount");
                        }
                       
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

                bool res;
                double number;
                res = double.TryParse(value, out number);
                
                if(res==true)
                {
                    double digit = Math.Floor(Math.Log10(number)+1);
                    if(digit<=10)
                    {
                        _ownercontactnumber = number.ToString();
                        RaisedPropertyChanged("OwnerContactNumber");
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
                if(IsAmount(value.ToString()) == true)
                {
                    if (value != _rentpermonth)
                    {
                        _rentpermonth = value;
                        RaisedPropertyChanged("RentPerMonth");
                    }
                }
                else
                {
                    throw new Exception("Invalid Amount");
                }

            }
        }
        public string AccountHolderName { get; set; }
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
                    double v;
                    bool result;
                    result = double.TryParse(value, out v);
                    if(result==true)
                    {
                        _accountnumber = v.ToString();
                        RaisedPropertyChanged("AccountNumber");
                    }
                    else
                    {
                        throw new ArgumentException("The Account Number is Invalid");
                    }
                      
                }
            }
        }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
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
        public bool IsAmount(string value)
        {
            int a;
            bool result = int.TryParse(value, out a);
            if(result!=true)
            {
                throw new ArgumentException("Invalid Amount");
            }
            return true;
            
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
        public override string ToString()
        {
            return (RegionName+BranchAddress+BranchName+RentPerMonth+IFSCCode+"\n"+MICRCode);
        }
    }
}
