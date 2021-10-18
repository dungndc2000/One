using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Four.Entity
{
    [Table("Product")]
    public class Product : BaseEntityIDInt
    {
        //ten,donvi,dongia

        [MaxLength(50)]
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }

        #region Relationship
        public ICollection<DetailsInvoice> DetailsInvoices { get; set; }
        #endregion
    }
}
