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
    public struct TimePeriod
    {
        private int period;
        private UnitOfTime unit;

        /// <summary>
        /// 
        /// </summary>
        public int Period
        {
            get { return period; }
            set { period = value; }
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
