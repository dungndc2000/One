using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Entity
{
    public class Product : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public string Unit { get; set; }
        public int UnitPrice { get; set; }


        #region Relationship
            public ICollection<DetailsInvoice> DetailsInvoices { get; set; }
        #endregion
    }
}
