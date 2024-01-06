using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Map.Options
{
    public class PaymentMap : BaseMap<Payment>
    {
        public PaymentMap()
        {
            Property( x => x.Price).HasColumnType("money");
        }
    }
}
