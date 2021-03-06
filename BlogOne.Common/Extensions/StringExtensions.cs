﻿using System;
using System.Text.RegularExpressions;

namespace BlogOne.Common.Extensions
{
    public static  class StringExtensions
    {
        public static bool HasValue(this string str)
        {
            return !String.IsNullOrEmpty(str);
        }

        public static string f(this string str, params object[] args)
        {
            if (str.HasValue())
            {
                return String.Format(str, args);
            }

            return str;
        }        
    }
}