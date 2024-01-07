using Dernek.Business.Abstract;
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
    public class MemberService : IMemberService
    {
        IMemberRepository memberRepository;
        IPaymentService paymentService;

        public MemberService()
        {
            memberRepository = new MemberRepository();
            paymentService = new PaymentService();
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

        public DataTable GetDebtorsByDate(DateTime startDate, DateTime endDate)
        {
            return memberRepository.GetDebtorsByDate(startDate, endDate);
        }

        public DataTable GetDebtorsByMonth(int month)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year, month, 1);
            DateTime endDate = startDate.AddMonths(1);
            List<Payment> payments = paymentService.GetByDateList(startDate, endDate);


        }

        public DataTable GetPayingUserByDate(DateTime startDate, DateTime endDate)
        {
            return memberRepository.GetPayingUserByDate(startDate, endDate);
        }

        public Member GetMemberById(string id)
        {
            return memberRepository.GetById(id);
        }

        public Member UpdateMember(Member member)
        {
            return memberRepository.Update(member);
        }
    }
}
