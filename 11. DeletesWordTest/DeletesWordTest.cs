//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class DeletesWordTest
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../InitialFile.txt"))
        {
            string line = reader.ReadLine();
            using (StreamWriter writer = new StreamWriter("../../OutputFile.txt"))
                while (line != null)
                {
                    string newLine = Regex.Replace(line, @"\btest(\w*)\b", "");
                    writer.WriteLine(newLine);
                    line = reader.ReadLine();
                }
        }
    }
}

