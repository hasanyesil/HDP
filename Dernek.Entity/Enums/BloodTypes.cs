using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Entity.Enums
{
    public enum BloodTypes : byte
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 

        /// <summary>
        /// A Positive
        /// </summary>
        AP = 1,

        /// <summary>
        /// A Negative
        /// </summary>
        AN = 2,

        /// <summary>
        /// B Positive
        /// </summary>
        BP = 3,

        /// <summary>
        /// B Negative
        /// </summary>
        BN = 4,

        /// <summary>
        /// 0 Positive
        /// </summary>
        ZP = 5,

        /// <summary>
        /// 0 Negative
        /// </summary>
        ZN = 6
    }
}
