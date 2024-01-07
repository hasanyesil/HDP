using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business.Abstract
{
    public interface IOrganizationService : IBaseService
    {
        decimal GetOrganizationFeeByMonth(int month);

        List<OrganizationFee> GetAll();
    }
}
