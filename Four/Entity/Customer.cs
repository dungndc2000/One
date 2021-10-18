using Four.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Four.Entity
{

    public class Customer : BaseEntityIDInt
    {
        //Id,Ten,DiaChi,NGaySinh,Gioitinh
        [MaxLength(50)]
        public string Name { get; set; }
        public String Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        #region Relationship
        public ICollection<Invoice> Invoices { get; set; }
        #endregion
    }
}
