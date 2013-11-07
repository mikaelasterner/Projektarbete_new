using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class MemberService
    {
        MemberRepository _memberRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public MemberService(RepositoryFactory repositoryFactory)
        {
            _memberRepository = repositoryFactory.GetMemberRepository();
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
    }
}
