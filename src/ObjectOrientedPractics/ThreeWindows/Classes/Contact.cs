using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeWindows.ArgumentsForEvents;

namespace ThreeWindows.Classes
{
    public class Contact
    {
        public event EventHandler<StringEventArgs> FullNameChanged;
        public event EventHandler<StringEventArgs> PhoneNumberChanged;
        public event EventHandler<StringEventArgs> AddressChanged;
        private string _fullName;
        private string _phoneNumber;
        private string _address;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (_fullName != value)
                {
                    StringEventArgs args = new StringEventArgs();
                    args.OldData = _fullName;
                    _fullName = value;
                    args.NewData = _fullName;
                    FullNameChanged?.Invoke(this, args);
                }
            }
        }
        public string PhoneNUmber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (_phoneNumber != value)
                {
                    StringEventArgs args = new StringEventArgs();
                    args.OldData = _phoneNumber;
                    _phoneNumber = value;
                    args.NewData = _phoneNumber;
                    PhoneNumberChanged?.Invoke(this, args);
                }
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (_address != value)
                {
                    StringEventArgs args = new StringEventArgs();
                    args.OldData = _address;
                    _address = value;
                    args.NewData = _address;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }
    }
}
