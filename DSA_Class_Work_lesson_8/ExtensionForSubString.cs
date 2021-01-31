using System;
using System.Text;

namespace DSA_Class_Work_lesson_11
{
   /* public static class ExtensionForSubString
    {
        public static StringBuilder Substring(this StringBuilder txt, int index)
        {
            StringBuilder substring = new StringBuilder();
            if (index < 0 || index > txt.Length - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            substring.Append(txt.ToString().Substring(index));
            return substring;
        }
        public static StringBuilder Substring(this StringBuilder txt, int index, int length)
        {
            StringBuilder substring = new StringBuilder();
            if (index < 0 || index > txt.Length - 1||length<=0||length>txt.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            substring.Append(txt.ToString().Substring(index, length));
            return substring;
        }
    }
   */
}
