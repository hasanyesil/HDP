using Dernek.Entity.Enums;
using System;
using System.Collections.Generic;

namespace Dernek.Entity.Models
{
    public class Member: BaseEntity
    {
        #region Public Properties
        public string Id { get; set; } //TCKN

        public string MemberName { get; set; }

        public string MemberSurname { get; set; }

        public BloodTypes BloodType { get; set; }

        public DateTime BirthDate { get; set; }

        public Cities City { get; set; }

        public MemberStatuses MemberStatus { get; set; }

        public string PhoneNumber { get; set; }

        #endregion Public Properties

    }
}
