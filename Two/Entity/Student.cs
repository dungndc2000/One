using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.Entity
{
    public class Student : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        #region Relationship

        public Guid MaKhoa { get; set; }
        public Department Department { get; set; }


        public ICollection<Instructor> Instructors { get; set; }
        #endregion
    }
}
