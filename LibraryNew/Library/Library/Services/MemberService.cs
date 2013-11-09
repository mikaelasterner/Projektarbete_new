using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class MemberService : IService
    {
        IRepository<Member, int> _memberRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public MemberService(IRepository<Member, int> repository)
        {
            _memberRepository = repository;
        }

        public void Add(Member member)
        {
            _memberRepository.Add(member);
        //utlös eventet för att lägga till en bok
        }

        public void Remove(Member member)
        {
            _memberRepository.Remove(member);
            //utlös eventet för att lägga till en bok
        }

        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }
    }
}
