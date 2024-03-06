using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSchool.Controls
{
    public class DisplayItem<T>
    {
        public T Value { get; set; }
        public string DisplayName { get; set; }

        public DisplayItem(T value, string displayName) 
        {
            Value = value;
            DisplayName = displayName;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
