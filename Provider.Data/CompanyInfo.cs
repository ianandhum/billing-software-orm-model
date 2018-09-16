using Provider.Data.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace Provider.Data
{
    [Table(Name = "CompanyInfo")]
    public class CompanyInfo: NotifyUIBase
    {
        private int _CompanyId;

        [Column(IsPrimaryKey = true, Name = "CompanyId", DbType = "INTEGER")]
        [Key]

        public int CompanyId
        {
            get
            {
                return _CompanyId;
            }
            set
            {
                _CompanyId = value;
                RaisePropertyChanged("CompanyId");

            }
        }


        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                RaisePropertyChanged("Name");

            }
        }

        private string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
                RaisePropertyChanged("Address");

            }
        }


        private string _ZIP;
        public string ZIP
        {
            get
            {
                return _ZIP;
            }
            set
            {
                _ZIP = value;
                RaisePropertyChanged("ZIP");

            }
        }

        private string _City;
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
                RaisePropertyChanged("City");

            }
        }


        private string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
                RaisePropertyChanged("Email");

            }
        }


        private string _Telephone;
        public string   Telephone
        {
            get
            {
                return _Telephone;
            }
            set
            {
                _Telephone = value;
                RaisePropertyChanged("Telephone");

            }
        }


        private string _TagLine;
        public string TagLine
        {
            get
            {
                return _TagLine;
            }
            set
            {
                _TagLine = value;
                RaisePropertyChanged("TagLine");

            }
        }

        private string _Place;
        public string Place
        {
            get
            {
                return _Place;
            }
            set
            {
                _Place = value;
                RaisePropertyChanged("Place");

            }
        }


        private string _GSTIN;
        public string GSTIN
        {
            get
            {
                return _GSTIN;
            }
            set
            {
                _GSTIN = value;
                RaisePropertyChanged("GSTIN");

            }
        }

        private string _State;
        public string State
        {
            get
            {
                return _State;
            }
            set
            {
                _State = value;
                RaisePropertyChanged("State");

            }
        }




    }
}
