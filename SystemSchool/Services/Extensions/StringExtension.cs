namespace Business.Extensions
{
    public static class StringExtension
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
