using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Four.Entity
{

    public class Invoice : BaseEntityIDInt
    {

        public int Price { get; set; }
        public DateTime? InvoiceDay { get; set; }

        #region Relationship
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public ICollection<DetailsInvoice> DetailsInvoices { get; set; }
        #endregion
    }
}
