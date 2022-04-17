using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Class for Custome Exception Handelling
    /// </summary>
    public class CabInvoiceException:Exception
    {
        /// <summary>
        /// Enum for Exception Type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALI_DISTANCE,
            INVALID_TIME,
            INVALID_RIDES,
            INVALID_USER_ID,
            NULL_RIDES
        }

         ExceptionType type;

        /// <summary>
        /// Parameter Constructor for setting Exception type and Throwing Exception
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
