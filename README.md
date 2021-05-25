# Home_assignment
Word wrapping problem in .NET

Application type - console application with unit tests
Project takes 2 command line arguments - path to file, containing text and line width
Wrapped text is outputed to answers.txt file
Words can be broken only when neccesary.

Example:

Input text            line width        Ouput

Green metal stick     13                Green metal
                                        stick
               
Establishment of the  7                 Establi
church                                  shment
                                        of the
                                        church

There are 2 cases:
  
  First: The word can fit into the last line
  Second: The word can't fit into the last line
    1: The word can fit in empty line
    2: The word can't fit in empty line and needs to be broken
 
Algorithm should track the last line lenght, so that it would know
when to insert a word, or break a line and then insert.

Before passing text to the algorithm, the text length should be checked.
If text.length < width
  return text;

Text taken from file can be filled with breaks and extra spaces.
Need to clean text before passing to algorithm.
Program requires 2 arguments or exit().
