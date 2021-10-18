using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Four.Entity
{

    public class DetailsInvoice : BaseEntity
    {
        
        public int Count { get; set; }

        #region Relationship
        
        public int InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }
      
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        
        
        #endregion

    }
}
