﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Class_Work_lesson_11
{
    public static class StringExtensions
    {
        public static StringBuilder Substring(this StringBuilder text, int startIndex)
        {
            if (startIndex < 0 || startIndex >= text.Length)
                throw new ArgumentOutOfRangeException();

            StringBuilder substring = new StringBuilder();

            for (int i = startIndex; i < text.Length; i++)
                substring.Append(text[i]);

            return substring;
        }

        public static StringBuilder Substring(this StringBuilder text, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= text.Length || startIndex + length > text.Length || length < 0)
                throw new ArgumentOutOfRangeException();

            StringBuilder substring = new StringBuilder();

            for (int i = startIndex; i < startIndex + length; i++)
                substring.Append(text[i]);

            return substring;
        }
    }
}
