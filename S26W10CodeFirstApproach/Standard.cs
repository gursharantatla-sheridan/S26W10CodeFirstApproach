using System;
using System.Collections.Generic;
using System.Text;

namespace S26W10CodeFirstApproach
{
    public class Standard
    {
        // scalar properties
        public int StandardId { get; set; }
        public string? StandardName { get; set; }

        // navigation properties
        public ICollection<Student>? Students { get; set; }
    }
}
