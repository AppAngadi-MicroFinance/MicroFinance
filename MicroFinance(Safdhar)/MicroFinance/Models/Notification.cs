using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFinance.Models
{
    public class Notification
    {
        Customer _customerObj = new Customer();
        public Customer CustomerObj
        {
            get
            {
                return _customerObj;
            }
            set
            {
                _customerObj = value;
            }
        }

        Nominee _nomineeObj = new Nominee();

        public Nominee NomineeObj
        {
            get
            {
                return _nomineeObj;
            }
            set
            {
                _nomineeObj = value;
            }
        }

         Guarantor guarantorObj=new Guarantor();
        public Guarantor GuarantorObj
        {
            get
            {
                return guarantorObj;
            }
            set
            {
                guarantorObj = value;
            }
        }

        
        
        public string NotificationFrom { get; set; }
        public string NotificationPurpose { get; set; }
        public string OfficerName { get; set; }
        public string BranchName { get; set; }
        public string NotificationDate { get; set; }


    }
}
