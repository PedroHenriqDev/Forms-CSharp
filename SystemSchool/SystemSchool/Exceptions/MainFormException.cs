using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSchool.Expections
{
    internal class MainFormException : Exception
    {
        public MainFormException(string message) : base(message) 
        {
        }
    }
}
