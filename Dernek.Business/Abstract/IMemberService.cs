using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business.Abstract
{
    public interface IMemberService : IBaseService
    {
        Member AddMember(Member member);

        Member UpdateMember(Member member);

        List<Member> GetAllMembers();
        DataTable GetAllMembersAsDataTable();
        Member GetMemberById(string id);

        DataTable GetDebtorsByDate(DateTime startDate,  DateTime endDate);

        DataTable GetPayingUserByDate(DateTime startDate, DateTime endDate);
    }
}
