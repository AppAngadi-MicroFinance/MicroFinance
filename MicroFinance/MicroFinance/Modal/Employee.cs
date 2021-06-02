using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace MicroFinance.Modal
{
    public class Employee:BindableBase
    {
        public List<String> BranchList = new List<string>();
        string Connectionstring = MicroFinance.Properties.Settings.Default.DBConnection;
        public Employee()
        {
            GetBranchList();
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
                if(value!=_branchname)
                {
                   
                    _branchname = value;
                     RaisedPropertyChanged("BranchName");
                    
                }
            }
        }
        private string _employeeID
        {
            get
            {
                return GetEmployeeID();
            }
        }
        private string _branchID
        {
            get
            {
                return GetBranchID();
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
                   
                   _designation = value;
                   RaisedPropertyChanged("Designation");
                  
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
               
               _employeename = value;
               RaisedPropertyChanged("EmployeeName");
               
            }
           
        }
        private DateTime _dob=DateTime.Now;
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
                _age = value;
                RaisedPropertyChanged("Age");
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
                   
                   _contactnumber = value;
                   RaisedPropertyChanged("ContactNumber");
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
                  _email = value;
                   RaisedPropertyChanged("Email");
                }
            }
        }
        private string _houseno;
        public string HouseNo
        {
            get
            {
                return _houseno;
            }
            set
            {
                _houseno = value;
                RaisedPropertyChanged("HouseNo");
            }
        }
        private string _townname;
        public string TownName
        {
            get
            {
                return _townname;
            }
            set
            {
                _townname = value;
                RaisedPropertyChanged("TownName");
            }
        }
        private string _district;
        public string District
        {
            get
            {
                return _district;
            }
            set
            {
                _district = value;
                RaisedPropertyChanged("District");
            }
        }
        private string _pincode;
        public string Pincode
        {
            get
            {
                return _pincode;
            }
            set
            {
                _pincode = value;
                RaisedPropertyChanged("Pincode");
            }
        }
        //

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
                    _aadharnumber = value;
                    RaisedPropertyChanged("Aadharnumber");
                }
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
                RaisedPropertyChanged("Religion");
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
                RaisedPropertyChanged("Education");
            }
        }
        private DateTime _dateofjoining=DateTime.Now;
        public DateTime DateOfJoining
        {
            get
            {
                return _dateofjoining.Date;
            }
            set
            {
                _dateofjoining = value;
                RaisedPropertyChanged("DateOfJoining");
            }
        }
        private string _addressproofName;
        public string AddressProofName
        {
            get
            {
                return _addressproofName;
            }
            set
            {
                _addressproofName = value;
                RaisedPropertyChanged("AddressProofName");
            }
        }
        private BitmapImage _addressproofimage;
        public BitmapImage AddressProofImage
        {
            get
            {
                return _addressproofimage;
            }
            set
            {
                _addressproofimage = value;
                RaisedPropertyChanged("AddressProofImage");
            }
        }

        private string _photoproofname;
        public string PhotoProofName
        {
            get
            {
                return _photoproofname;
            }
            set
            {
                _photoproofname = value;
                RaisedPropertyChanged("PhotoProofName");
            }
        }
        private BitmapImage _photoproofimage;
        public BitmapImage PhotoProofImage
        {
            get
            {
                return _photoproofimage;
            }
            set
            {
                _photoproofimage = value;
                RaisedPropertyChanged("PhotoProofImage");
            }
        }
        private BitmapImage _profileimage;
        public BitmapImage ProfileImage
        {
            get
            {
                return _profileimage;
            }
            set
            {
                _profileimage = value;
                RaisedPropertyChanged("ProfileImage");
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
              _accountnumber = value;
              RaisedPropertyChanged("Account Number");
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
                if (value != _ifsccode)
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
        public void EmployeeAdd()
        {
            if(!IsExists())
            {
                using (SqlConnection sqlConn = new SqlConnection(Connectionstring))
                {
                    sqlConn.Open();
                    SqlCommand Sqlcomm = new SqlCommand();
                    Sqlcomm.Connection = sqlConn;
                    Sqlcomm.CommandText = "insert into Employee(EmpId,Name,DOB,age,MobileNo,Region,EmailId,Education,AadhaarNo,DateOfJoin,BankName,BranchName,AccountNumber,IFSCCode,MICRCode,Address,PinCode,District,IsAddressProof,AddressProofName,AddressProof,IsPhotoProof,PhotoProofName,PhotoProof,IsProfilePhoto,ProfilePhoto,IsActive,Designation,Bid)values('" + _employeeID + "','" + EmployeeName + "','" + _dob.ToString("MM/dd/yyyy") + "','" + Age + "','" + _contactnumber + "','" + _religion + "','" + _email + "','" + _education + "','" + _aadharnumber + "','" + DateOfJoining.ToString("MM/dd/yyyy") + "','" + _bankname + "','" + BankBranchName + "','" + _accountnumber + "','" + _ifsccode + "','" + _micrcode + "','" + (_houseno + _townname) + "','" + _pincode + "','" + _district + "'," + 1 + ",'" + _addressproofName + "',@addressproof,1,'" + _photoproofname + "',@photoproof,1,@profilepicture,1,'" + _designation + "','" + _branchID + "')";
                    Sqlcomm.Parameters.AddWithValue("@addressproof", Convertion(_addressproofimage));
                    Sqlcomm.Parameters.AddWithValue("@photoproof", Convertion(_photoproofimage));
                    Sqlcomm.Parameters.AddWithValue("@profilepicture", Convertion(_profileimage));
                    Sqlcomm.ExecuteNonQuery();
                    sqlConn.Close();
                }
            }
           
        }
        public string GetBranchID()
        {
            string ID = "";
            using(SqlConnection sqlconn=new SqlConnection(Connectionstring))
            {
                sqlconn.Open();
                if(sqlconn.State==ConnectionState.Open)
                {
                    SqlCommand sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlconn;
                    sqlcomm.CommandText = "(select Bid from BranchDetails where BranchName='"+_branchname+"')";
                    ID = (string)sqlcomm.ExecuteScalar();
                }
                sqlconn.Close();
            }
            return ID;
        }

        public string GetEmployeeID()
        {
            int number = 1;
            using (SqlConnection sqlconn = new SqlConnection(Connectionstring))
            {
                sqlconn.Open();
                if (sqlconn.State == ConnectionState.Open)
                {
                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm.Connection = sqlconn;
                    sqlComm.CommandText = "select count(Name) from Employee";
                    int n = (int)sqlComm.ExecuteScalar();
                    number += n;
                }
                sqlconn.Close();
            }
            string ID = (_branchname[0].ToString() + _designation[0].ToString() + number.ToString());
            return ID;
        }

        public bool IsExists()
        {
           using(SqlConnection sqlconn=new SqlConnection(Connectionstring))
            {
                sqlconn.Open();
                if(sqlconn.State==ConnectionState.Open)
                {
                    SqlCommand sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlconn;
                    sqlcomm.CommandText = "select * from Employee where Name='"+_employeename+"' and AadhaarNo='"+_aadharnumber+"'";
                    SqlDataReader reader = sqlcomm.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            if(reader.GetString(1)==_employeename&&reader.GetString(8)==_aadharnumber)
                            {
                                return true;
                            }
                        }
                    }
                }
                sqlconn.Close();
            }
            return false;
        }
        public byte[] Convertion(BitmapImage image)
        {
            byte[] Data;
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                Data = ms.ToArray();
            }
            return Data;
        }
        public void GetBranchList()
        {
            BranchList = new List<string>();
            using(SqlConnection sqlconn=new SqlConnection(Connectionstring))
            {
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlconn;
                sqlcomm.CommandText = "select BranchName from BranchDetails";
                SqlDataReader reader = sqlcomm.ExecuteReader();
                while(reader.Read())
                {
                    BranchList.Add(reader.GetString(0));
                }
                reader.Close();
                sqlconn.Close();
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
