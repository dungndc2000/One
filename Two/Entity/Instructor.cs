using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.Entity
{
    public class Instructor : BaseEntityNotID
    {
        [MaxLength(50)]
        public string Result { get; set; }
        
        
        #region Relationship
        public Guid MaSv { get; set; }
        public Student Student { get; set; }

        public Guid Magv { get; set; }
        public Teacher Teacher { get; set; }

        public Guid Madt { get; set; }
        public Topic Topic { get; set; }

        
        #endregion
    }
}
