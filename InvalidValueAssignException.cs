using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPL_APP
{
    /// <summary>
    /// Exception for invalid value assignment.
    /// </summary>
    class InvalidValueAssignException: Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public InvalidValueAssignException() : base("Invalid command given.") { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public InvalidValueAssignException(string message) : base(message) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public InvalidValueAssignException(string message, System.Exception inner) : base(message, inner) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected InvalidValueAssignException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
