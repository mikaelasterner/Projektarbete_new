using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Models
{
    class Loan
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public DateTime DueDate { get; set; } //kan man använda datatypen timespan istället?
        public DateTime? ReturnTime { get; set; }
        public BookCopy Book_copy { get; set; }
        public Member Member { get; set; }
    }
}
