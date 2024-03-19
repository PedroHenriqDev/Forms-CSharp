using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSchool.Expections
{
    /// <summary>
    /// Represents an exception specific to the MainForm class in the SystemSchool namespace.
    /// </summary>
    internal class MainFormException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainFormException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MainFormException(string message) : base(message)
        {
        }
    }
}
