using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.Entity
{
    public class Topic : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        #region Relationship
        public ICollection<Instructor> Instructors { get; set; }
        #endregion
    }
}
