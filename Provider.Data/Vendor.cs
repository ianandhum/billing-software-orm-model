using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using Provider.Data.Support;

namespace Provider.Data
{
    public class Vendor:NotifyUIBase
    {
        public Vendor()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        private int _VendorId { get; set; }

        [Column(IsPrimaryKey = true)]
        [Key]
        public int VendorId
        {
            get
            {
                return _VendorId;
            }
            set
            {
                _VendorId = value;
                RaisePropertyChanged("VendorId");

            }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                RaisePropertyChanged("Email");
            }
        }

        private string _Telephone;

        public string Telephone
        {
            get { return _Telephone; }
            set
            {
                _Telephone = value;
                RaisePropertyChanged("Telephone");
            }
        }

        private string _BillingAddress;

        public string BillingAddress
        {
            get { return _BillingAddress; }
            set
            {
                _BillingAddress = value;
                RaisePropertyChanged("BillingAddress");
            }
        }

        private string _BillingZIP;

        public string BillingZIP
        {
            get { return _BillingZIP; }
            set
            {
                _BillingZIP = value;
                RaisePropertyChanged("BillingZIP");
            }
        }

        private string _BillingCity;

        public string BillingCity
        {
            get { return _BillingCity; }
            set
            {
                _BillingCity = value;
                RaisePropertyChanged("BillingCity");
            }
        }


        private string _ShippingAddress;

        public string ShippingAddress
        {
            get { return _ShippingAddress; }
            set
            {
                _ShippingAddress = value;
                RaisePropertyChanged("ShippingAddress");
            }
        }

        private string _ShippingZIP;

        public string ShippingZIP
        {
            get { return _ShippingZIP; }
            set
            {
                _ShippingZIP = value;
                RaisePropertyChanged("ShippingZIP");
            }
        }

        private string _ShippingCity;

        public string ShippingCity
        {
            get { return _ShippingCity; }
            set
            {
                _ShippingCity = value;
                RaisePropertyChanged("ShippingCity");
            }
        }

        private string _Details;

        public string Details
        {
            get { return _Details; }
            set
            {
                _Details = value;
                RaisePropertyChanged("Details");
            }
        }

        private string _GSTIN;

        public string GSTIN
        {
            get { return _GSTIN; }
            set
            {
                _GSTIN = value;
                RaisePropertyChanged("GSTIN");
            }
        }


        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
