namespace Business.Extensions
{
    /// <summary>
    /// Provides extension methods for string manipulation.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Cuts the complete name to the first part.
        /// </summary>
        /// <param name="thisObj">The string to manipulate.</param>
        /// <returns>The first part of the string.</returns>
        public static string CutCompleteName(this string thisObj)
        {
            if (thisObj == null)
            {
                return thisObj;
            }

            string[] cutName = thisObj.Split(' ');
            return cutName[0];
        }
    }
}
