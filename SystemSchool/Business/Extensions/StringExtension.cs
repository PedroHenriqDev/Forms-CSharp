using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Extensions
{
    static class StringExtension
    {
        static public string CutCompleteName(this string thisObj) 
        {
            if(thisObj == null)
            {
                return thisObj;
            }

            string[] cutName = thisObj.Split(' ');
            return cutName[0];
        }
    }
}
