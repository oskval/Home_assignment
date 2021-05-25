using System;
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

            /// <summary>
        /// Method wrapps text by targeted width
        /// </summary>
        /// <param name="input">Unwrapped text</param>
        /// <param name="width">Line width</param>
        /// <returns>Wrapped text</returns>
        public string Wrap(string input, int width)
            {
                // Is the full text width smaller then wanted ?
                if(input.Length <= width)
                    return input;

                string output = String.Empty;

                // Create an array of strings
                string[] wordArray = input.Split(" ");

                // Used for finding insert points
                int lastLineLength = 0;

                for (int i = 0; i < wordArray.Length; i++)
                {
                    // If word can be inserted into last line
                    if (lastLineLength + wordArray[i].Length <= width)
                    {
                        if (i != 0)
                        {
                            output += " ";
                            lastLineLength++;
                        }

                        output += wordArray[i];
                        lastLineLength += wordArray[i].Length;
                    }
                    else if (lastLineLength + wordArray[i].Length >= width)
                    {
                        // If the word can be inserted into an empty line
                        if (wordArray[i].Length <= width)
                        {
                            output = output.Insert(output.Length, "\n") + wordArray[i];
                            lastLineLength = wordArray[i].Length + 1;
                        }
                        // If the word does not fit into a line by itself
                        else if (wordArray[i].Length > width)
                        {
                            if (i != 0)
                            {
                                output += "\n";
                                lastLineLength++;
                            }
                            int chunkWidth = (wordArray[i].Length / width) + 1;
                            int extraPosition = 0;
                            
                            // Iteration over chuncks
                            for (int j = 1; j < chunkWidth; j++)
                            {
                                wordArray[i] = wordArray[i].Insert((width * j) + extraPosition, "\n");
                                extraPosition++;
                            }
                            output += wordArray[i];
                            lastLineLength = wordArray[i].Length - wordArray[i].LastIndexOf("\n") - 1;
                        }

                    }

                }

                return output;
            }
    }
}