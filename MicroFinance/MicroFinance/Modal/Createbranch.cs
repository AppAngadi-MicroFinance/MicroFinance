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
                   _regionName = value;
                   RaisedPropertyChanged("RegionName");
                     
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
                _landlinenumber = value;
                 RaisedPropertyChanged("LandlineNumber"); 
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
              
                        _costpermonth = value;
                        RaisedPropertyChanged("CostPerMonth");
              
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
               
                 _ebconnectionname = value;
                  RaisedPropertyChanged("EbConnectionName");
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
               
                _ebconnectionnubmer = value;
                  RaisedPropertyChanged("EBConnectionNumber");
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
                     
                         _internetconnectioncost = value;
                         RaisedPropertyChanged("InternetConnectionCost");
                       
                        
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
                   
                     _ownercontactnumber = value;
                      RaisedPropertyChanged("OwnerContactNumber");
                      
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
               
                    _rentpermonth = value;
                    RaisedPropertyChanged("RentPerMonth");
               
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
                if(value!=_accountnumber)
                {
                   
                   _accountnumber = value;
                   RaisedPropertyChanged("Account Number");
                      
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
       
    }
}
