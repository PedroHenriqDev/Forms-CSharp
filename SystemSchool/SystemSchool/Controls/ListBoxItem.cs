using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSchool.Controls
{
    public class ListBoxItem<T>
    {
        public T Value { get; set; }
        public string DisplayName { get; set; }

        public ListBoxItem(T value, string displayName) 
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
