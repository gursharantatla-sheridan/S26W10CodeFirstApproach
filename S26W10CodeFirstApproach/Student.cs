using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace S26W10CodeFirstApproach
{
    public class Student
    {
        // scalar properties
        public int StudentId { get; set; }

        [Column("Name")]
        public string? StudentName { get; set; }
        public int? StandardId { get; set; }
        public int? Age { get; set; }

        // navigation properties
        public Standard? Standard { get; set; }
    }
}
