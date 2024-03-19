using System;

namespace SystemSchool.Controls
{
    /// <summary>
    /// Represents an item to be displayed in a control, containing both a value and a display name.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public class DisplayItem<T>
    {
        /// <summary>
        /// Gets or sets the value of the display item.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the display name of the display item.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayItem{T}"/> class with the specified value and display name.
        /// </summary>
        /// <param name="value">The value of the display item.</param>
        /// <param name="displayName">The display name of the display item.</param>
        public DisplayItem(T value, string displayName)
        {
            Value = value;
            DisplayName = displayName;
        }

        /// <summary>
        /// Returns the display name of the display item.
        /// </summary>
        /// <returns>The display name of the display item.</returns>
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
