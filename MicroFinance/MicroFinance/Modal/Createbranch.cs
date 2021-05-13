using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFinance.Modal
{
    class Createbranch
    {
        public Createbranch()
        {
            this._costpermonth = 0;
        }
        public string RegionName { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string LandlineNumber { get; set; }
        int _costpermonth;
        public string CostPerMonth
        {
            get
            {
                return _costpermonth.ToString();
            }
            set
            {
                _costpermonth = int.Parse(value);
            } 
        }
        public string ManagerName { get; set; }
        public string AccountantName { get; set; }
        public DateTime OpeningDate { get; set; }
        public string EBConnectionName { get; set; }
        public string EBConnectionNumber { get; set; }
        public string InternetConnectionName { get; set; }
        public int InternetConnectionCost { get; set; }
        public string OwnerName { get; set; }
        public string OwnerContactNumber { get; set; }
        public string OwnerAddress { get; set; }
        public int AdvancePaid { get; set; }
        public int RentPerMonth { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string IFSCCode { get; set; }
        public string MICRCODE { get; set; }

    }
}
