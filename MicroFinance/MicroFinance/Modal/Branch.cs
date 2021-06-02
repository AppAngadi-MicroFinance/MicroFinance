using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MicroFinance.Modal
{
    class Branch:BindableBase
    {
        public List<string> RegionList = new List<string>();
        
        private string ConnectionString = Properties.Settings.Default.DBConnection;
        public Branch()
        {
            GetRegionList();
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
        int _landlinecostpermonth;
        public int CostPerMonth
        {
            get
            {
                return _landlinecostpermonth;
            }
            set
            {
              
                        _landlinecostpermonth = value;
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
        private DateTime _openingdate = DateTime.Today;
        public DateTime OpeningDate
        {
            get
            {
                return _openingdate;
            }
            set
            {
                _openingdate = value;
                RaisedPropertyChanged("OpeningDate");
            }
        }
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
        private string _ownername;
        public string OwnerName
        {
            get
            {
                return _ownername;
            }
            set
            {
                _ownername = value;
                RaisedPropertyChanged("OwnerName");
            }
        }
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
        public string OwnerAddress
        {
            get;
            set;
        }
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

        public void GetRegionList()
        {
            using (SqlConnection sqlconn=new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                if(sqlconn.State == ConnectionState.Open)
                {
                    SqlCommand sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlconn;
                    sqlcomm.CommandText = "Select RegionName from Region";
                    SqlDataReader sqlDataReader = sqlcomm.ExecuteReader();
                    while(sqlDataReader.Read())
                    {
                        RegionList.Add(sqlDataReader.GetString(0));
                    }
                    sqlDataReader.Close();
                }
                sqlconn.Close();
            }
        }
        public string GetBranchID()
        {
            int number = 1;
            using(SqlConnection sqlconn=new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                if(sqlconn.State == ConnectionState.Open)
                {
                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm.Connection = sqlconn;
                    sqlComm.CommandText = "select count(BranchName) from BranchDetails";
                    int n = (int)sqlComm.ExecuteScalar();
                    number += n;
                }
                sqlconn.Close();
            }
            string ID = (_regionName[0].ToString() + BranchName[0].ToString() + number.ToString());
            return ID;
        }
        public void AddBranch()
        {
            if(!IsExists())
            {
                using (SqlConnection sqlconn = new SqlConnection(ConnectionString))
                {
                    sqlconn.Open();
                    if (sqlconn.State == ConnectionState.Open)
                    {
                        SqlCommand sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlconn;
                        sqlcomm.CommandText = "insert into BranchDetails(Bid,RegionName,BranchName,Address,LandLineNumber,LandLineCost,DateofCreation,EBNumber,EBConnectionName,InternetConnectionName,InternetCost,BuildingOwnerName,OwnerContact,OwnerAddress,AdvancePaid,MonthlyRent,OwnerACBankName,OwnerACBranchName,AccountHolderName,AccountNumber,IFSCCode,MICRCode)values('" + GetBranchID() + "','" + _regionName + "','" + _branchname + "','" + _branchaddress + "','" + _landlinenumber + "'," + _landlinecostpermonth + ",'" + _openingdate.ToString("dd/MM/yyyy") + "','" + _ebconnectionnubmer + "','" + _ebconnectionname.ToUpper() + "','" + InternetConnectionName + "'," + _internetconnectioncost + ",'" + OwnerName + "','" + _ownercontactnumber + "','" + OwnerAddress + "'," + _advancepaid + "," + _rentpermonth + ",'" + _bankname + "','" + _bankbranchname + "','" + _accountholdername + "','" + _accountnumber + "','" + _ifsccode + "','" + MICRCode + "')";
                        sqlcomm.ExecuteNonQuery();
                    }
                    sqlconn.Close();
                }
            }
            else
            {
                throw new ArgumentException("The Branch Already in this Region!...");
            }
            
        }

        public bool IsExists()
        {
            using(SqlConnection sqlconn=new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                if(sqlconn.State==ConnectionState.Open)
                {
                    SqlCommand sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlconn;
                    sqlcomm.CommandText = "select RegionName,BranchName from BranchDetails where RegionName = '"+_regionName+"' and BranchName = '"+_branchname+"'";
                    SqlDataReader reader = sqlcomm.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            if(reader.GetString(0)==_regionName&&reader.GetString(1)==_branchname)
                            {
                                return true;
                            }
                        }
                    }
                    reader.Close();
                }
                sqlconn.Close();
            }
            return false;
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
