using System;
using System.Collections.Generic;
using System.Text;

namespace TDDAuthenticationSprint.Search
{
    public static class KeywordCheck
    {
        public static bool isSufficientLength(string keyword)
        {
            return keyword.Length >= 3;
        }
    }
}
