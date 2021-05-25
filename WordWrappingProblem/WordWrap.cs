using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

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

        /// <summary>
        /// Method wrapps text by targeted width
        /// </summary>
        /// <param name="input">Unwrapped text</param>
        /// <param name="width">Line width</param>
        /// <returns>Wrapped text</returns>
        public IEnumerable<string> Wrap(string input, int width)
        {
            const string wordBreakPattern = @"\n";
            const string wordSeparationPattern = @"\s+|";

            var forcedZones = Regex.Matches(input, wordBreakPattern).Cast<Match>().ToList();
            var normalZones = Regex.Matches(input, wordSeparationPattern).Cast<Match>().ToList();

            int start = 0;

            while (start < input.Length)
            {
                var zone =
                    forcedZones.Find(z => z.Index >= start && z.Index <= start + width) ??
                    normalZones.FindLast(z => z.Index >= start && z.Index <= start + width);

                if (zone == null)
                {
                    yield return input.Substring(start, width);
                    start += width;
                }
                else
                {
                    yield return input.Substring(start, zone.Index - start);
                    start = zone.Index + zone.Length;
                }
            }
        }
    }
}