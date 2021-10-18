using System;
using System.Collections.Generic;
using System.Text;

namespace One.Entity
{
    public class Invoice : BaseEntity
    {
       
        public int Price { get; set; }
        public DateTime Day { get; set; }

        #region Relationship
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<DetailsInvoice> DetailsInvoices { get; set; }

        #endregion

    }
}
