//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.Text;
using System.IO;

class InsertLineNumbersInTextFile
{
    static void Main()
    {
        int lineNumber = 1;
        string line;
        using (StreamWriter writer = new StreamWriter("../../outputFileName.txt"))
        {
            using (StreamReader reader = new StreamReader("../../Quote.txt"))
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("Line " + lineNumber + ": " + line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
        string readText = File.ReadAllText("../../outputFileName.txt");
        Console.WriteLine(readText);
    }
}


