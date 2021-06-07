using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MicroFinance.Modal
{
    class Region:BindableBase
    {
        public string ConnectionString = MicroFinance.Properties.Settings.Default.DBConnection;
        private string _regionname;
        public string RegionName
        {
            get
            {
                return _regionname;
            }
            set
            {
                _regionname = value;
                RaisedPropertyChanged("RegionName");
            }
        }
        public void AddRegion()
        {
            using(SqlConnection sqlconn=new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                if(sqlconn.State==ConnectionState.Open)
                {
                    SqlCommand sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlconn;
                    sqlcomm.CommandText = "insert into Region (RegionName)values('" + _regionname + "')";
                    sqlcomm.ExecuteNonQuery();
                }
                sqlconn.Close();
            }
        }
    }
}
