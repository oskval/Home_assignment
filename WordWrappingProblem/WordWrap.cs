using System.Text.RegularExpressions;

namespace WordWrappingProblem
{
    public class WordWrap
    {
            /// <summary>
            /// Method fixes broken or messed up strings
            /// </summary>
            /// <param name="input">a bad string</param>
            /// <returns>a fixed string</returns>
            public string FixStrings(string input)
            {
                string text = Regex.Replace(input, "\\s+|\\n", " ");
                return text;
            }
    }
}