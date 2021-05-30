using System;

namespace Replace
{
    public static class Replace
    {
        private const string NEW_TEXT = "%20";

        public static string ReplaceSpaces(string str, int length)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }

            if (length > str.Length || length < 0)
            {
                throw new ArgumentException();
            }

            return str[..length].Replace(" ", NEW_TEXT);
        }
    }
}