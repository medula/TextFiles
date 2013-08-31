//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

class ReplaceWholeWords
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
                    string newLine = Regex.Replace(line, @"\bstart\b","finish");
                    writer.WriteLine(newLine);
                    line = reader.ReadLine();
                }
        }
    }
}

