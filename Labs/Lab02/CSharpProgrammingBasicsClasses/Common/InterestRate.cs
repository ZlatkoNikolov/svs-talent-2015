using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    /// <summary>
    /// 
    /// </summary>
    public struct InterestRate
    {
        private decimal percent;
        private UnitOfTime unit;

        /// <summary>
        /// 
        /// </summary>
        public decimal Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        
        /// <summary>
        /// 
        /// </summary>
        public UnitOfTime Unit
        {
            get { return unit; }
            set { unit = value; }
        }

    }
}
