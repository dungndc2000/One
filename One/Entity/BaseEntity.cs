using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Entity
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
            Status = Status.Active;

        }

        [Key]
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public Status Status { get; set; }

        
    }

    public enum Status
    {
        InActive = 0,
        Active = 1,
        Delete = 2
    }
}
