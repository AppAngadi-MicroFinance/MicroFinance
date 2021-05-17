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
        public string RegionName { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string LandlineNumber { get; set; }
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
        public string ManagerName { get; set; }
        public string AccountantName { get; set; }
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
        public int InternetConnectionCost
        {
            get
            {
                return _internetconnectioncost;
            }
            set
            {
                if(value!=_internetconnectioncost)
                {
                    _internetconnectioncost = value;
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
        public override string ToString()
        {
            return (RegionName+BranchAddress+BranchName+RentPerMonth+IFSCCode+"\n"+MICRCode);
        }
    }
}
