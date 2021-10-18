using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Two.Entity
{
    public class Book : BaseEntityIntKeyIndentity
    {
        [Column("BookID")]
        

        public string Name { get; set; }

        public int Count { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
