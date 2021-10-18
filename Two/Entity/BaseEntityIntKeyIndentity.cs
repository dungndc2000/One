using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Two.Entity
{
    public class BaseEntityIntKeyIndentity
    {
        public BaseEntityIntKeyIndentity()
        {
            CreateDate = DateTime.Now;
            Status = Status.Active;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public Status Status { get; set; }
    }
}
