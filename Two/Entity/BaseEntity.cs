using System;
using System.Collections.Generic;
using System.Text;

namespace Two.Entity
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
            Status = Status.Active;
        }
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public Status Status { get; set; }

    }

    public enum Status
    {
        Active = 0,
        UnActive = 1,
        Delete = 2
    }
}
