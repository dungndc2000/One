    using One.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Entity
{
    public class Customer : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }


        #region Relationship

        public ICollection<Invoice> Invoices { get; set; }

        #endregion

    }
}
