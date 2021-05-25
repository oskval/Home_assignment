using System;
using System.IO;

namespace WordWrappingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Are all the inputs present ?
            if (args.Length < 2)
            {
                System.Console.WriteLine("No input");
                System.Console.WriteLine("Usage: dotnet run '{txt file path}' {line width}");
                Environment.Exit(0);
            }

            string textFromFile = File.ReadAllText(args[0]);

             // Is the width bigger then the text length ?
            if (Int32.Parse(args[1]) > textFromFile.Length)
            {
                File.WriteAllText("./answers.txt", textFromFile);
                System.Console.WriteLine("Input width was bigger then the text width");
                Environment.Exit(0);
            }

            // Class declaration
            var wordWrap = new WordWrap();

            // String fixing and wrapping
            string fixedText = wordWrap.FixStrings(textFromFile);
            string outputToWrite = wordWrap.Wrap(fixedText, Int32.Parse(args[1]));

            // Write final answers to file
            File.WriteAllText("./answers.txt", outputToWrite);
        }
    }
}
