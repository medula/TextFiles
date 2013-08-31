//Write a program that replaces all occurrences of the substring "start" with the substring "finish" 
//in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

class ReplacingOccurances
{
    static void Main()
    {
        string doc = "../../StartDoc.txt";
        using (StreamReader reader = new StreamReader(doc))
        {
            string line = reader.ReadLine();
            using (StreamWriter writer = new StreamWriter("../../FinishDoc.txt"))
                while (line != null)
                {
                    string newLine = Regex.Replace(line, "start", "finish");
                    writer.WriteLine(newLine);
                    line = reader.ReadLine();
                }
        }
    }
}


