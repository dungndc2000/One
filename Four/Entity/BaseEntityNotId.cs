using System;
using System.Collections.Generic;
using System.Text;

namespace Four.Entity
{
    public class BaseEntityNotId
    {
        public BaseEntityNotId()
        {
            CreateDate = DateTime.Now;
            Status = Status.Active;
        }

        public DateTime CreateDate { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public Status Status { get; set; }
    }
}
