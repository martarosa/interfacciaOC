using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

namespace INTOC
{
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input)
        {
            if (input == null)
                return null;

            if (input.Length > 1)
                return char.ToUpper(input[0]) + input.Substring(1);

            return input.ToUpper();
        }

        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }

}
