using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.Entity
{
    public class Department : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public char NumberPhone { get; set; }

        #region Relationship
        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        #endregion
    }
}
