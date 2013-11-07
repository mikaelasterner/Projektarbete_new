using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Models
{
    class Member
    {
        public int Id { get; set; }
        public int PrId { get; set; }
        public string Name { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
