using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
    public static class NameValidator
    {
        public static bool NameValidate(string input)
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                return true;

            return false;
        }
    }
}
