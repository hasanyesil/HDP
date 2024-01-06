using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Entity.Models
{
    public class Payment: BaseEntity
    {
        #region Public Properties
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime PaymentDate { get; set; }

        public string MemberId { get; set; }

        #endregion Public Properties

    }
}
