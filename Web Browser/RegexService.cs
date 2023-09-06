using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Web_Browser
{
    internal class RegexService
    {
        /// <summary>
        /// Perform regex on string.
        /// </summary>
        /// <param name="input">Input to perform regex on.</param>
        /// <param name="pattern">Regex pattern to use.</param>
        /// <returns>String after regex.</returns>
        public string DoRegexMagic(string input, string pattern)
        {
            return Regex.Replace(input, pattern, string.Empty);
        }
    }
}
