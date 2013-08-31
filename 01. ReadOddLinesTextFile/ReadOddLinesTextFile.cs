//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class ReadOddLinesTextFile
{
    static void Main()
    {
        int lineNumber = 1;
        string line;
        using (StreamReader reader = new StreamReader("../../Quote.txt"))
        {
            line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }
}

