using Dernek.DataAccess.Abstract;
using Dernek.DataAccess.Concrates;
using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business
{
    public class MemberService
    {
        IMemberRepository memberRepository;

        public MemberService()
        {
            memberRepository = new MemberRepository();
        }

        public Member AddMember(Member member)
        {
            return memberRepository.Insert(member);
        }

        public List<Member> GetAllMembers()
        {
            return memberRepository.GetAll();
        }

        public DataTable GetAllMembersAsDataTable()
        {
            return memberRepository.GetAllAsDt();
        }
    }
}
