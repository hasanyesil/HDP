using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Abstract
{
    public interface IOrganizationRepository : IBaseRepository<OrganizationFee>
    {
        OrganizationFee GetByMonth(int month);
    }
}
