using System;
using System.Collections.Generic;
using System.Text;

namespace S26W10CodeFirstApproach
{
    public class Student
    {
        // scalar properties
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int? StandardId { get; set; }

        // navigation properties
        public Standard? Standard { get; set; }
    }
}
