using Provider.Data.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Provider.Data
{
    public class MetaData:NotifyUIBase
    {


        public MetaData(DataContext AppDataContext)
        {

            try
            {
                CompanyInfo = (AppDataContext.CompanyInfo.ToList().Count != 0) ? AppDataContext.CompanyInfo.First() : null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public CompanyInfo CompanyInfo { get; set; }

        public InvoiceMeta Invoice { get; set; }

        public PurchaseMeta Purchase { get; set; }

        public class InvoiceMeta : NotifyUIBase
        {



            private string _TypeOnPrint;
            public string TypeOnPrint
            {
                get
                {
                    return _TypeOnPrint;
                }
                set
                {
                    _TypeOnPrint = value;
                    RaisePropertyChanged("TypeOnPrint");

                }
            }

            private string _Prefix;
            public string Prefix
            {
                get
                {
                    return _Prefix;
                }
                set
                {
                    _Prefix = value;
                    RaisePropertyChanged("Prefix");

                }
            }

            private string _NextInvoiceId;
            public string NextInvoiceId
            {
                get
                {
                    return _NextInvoiceId;
                }
                set
                {
                    _NextInvoiceId = value;
                    RaisePropertyChanged("NextInvoiceId");

                }
            }
        }


        public class PurchaseMeta : NotifyUIBase
        {



            private string _TypeOnPrint;
            public string TypeOnPrint
            {
                get
                {
                    return _TypeOnPrint;
                }
                set
                {
                    _TypeOnPrint = value;
                    RaisePropertyChanged("TypeOnPrint");

                }
            }

            private string _Prefix;
            public string Prefix
            {
                get
                {
                    return _Prefix;
                }
                set
                {
                    _Prefix = value;
                    RaisePropertyChanged("Prefix");

                }
            }

            private string _NextPurchaseId;
            public string NextPurchaseId
            {
                get
                {
                    return _NextPurchaseId;
                }
                set
                {
                    _NextPurchaseId = value;
                    RaisePropertyChanged("NextPurchaseId");

                }
            }
        }

    }
}
