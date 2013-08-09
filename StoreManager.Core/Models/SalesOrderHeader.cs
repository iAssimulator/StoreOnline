using System;
using System.Collections.Generic;
using StoreOnline.Core.Models;

namespace StoreOnline.Core.Models
{
    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new List<SalesOrderDetail>();
        }

        public int SalesOrderID { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int StatusID { get; set; }
        public bool OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public int CustomerID { get; set; }
        public int ContactID { get; set; }
        public int? SalesPersonID { get; set; }
        public int BillToAddressID { get; set; }
        public int ShipToAddressID { get; set; }
        public int ShipMethodID { get; set; }
        public int? CreditCardID { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public int? CurrencyRateID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public string Comment { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual OrderState OrderState { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual CreditCard CreditCard { get; set; }
        public virtual CurrencyRate CurrencyRate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
