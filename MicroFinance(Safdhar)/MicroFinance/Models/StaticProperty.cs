using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroFinance.Validations;

namespace MicroFinance.Models
{
    public class StaticProperty:BindableBase
    {

        private int _messageType = 0;

        public int MessageType
        {
            get
            {
                return _messageType;
            }
            set
            {
                _messageType = value;
                RaisePropertyChanged("MessageType");
            }
        }

        private string _statusMessage="Ready";

        public  string StatusMessage
        {
            get
            {
                return _statusMessage;
            }
            set
            {
                _statusMessage = value;
                RaisePropertyChanged("StatusMessage");
            }
        }
    }
}
