using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Entity
{
    public class DetailsInvoice : BaseEntityNotID
    {
        
        public int Quantity { get; set; }

        #region Relationship
       
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
       
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        #endregion
    }
}
