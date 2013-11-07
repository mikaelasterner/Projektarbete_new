using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Member member)
        {
            //sparar bok i databasen
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void Remove(Member member)
        {
            _context.Members.Remove(member);
            _context.SaveChanges();
        }
    }
}
