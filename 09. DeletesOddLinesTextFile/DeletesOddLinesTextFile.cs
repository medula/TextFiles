//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


class DeletesOddLinesTextFile
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../Quote.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../QuoteTMP.txt"))
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        line = null;
                        writer.WriteLine(line);
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }

        File.Copy("../../QuoteTMP.txt","../../Quote.txt", true);

        File.Delete("../../QuoteTMP.txt");

    }
}

