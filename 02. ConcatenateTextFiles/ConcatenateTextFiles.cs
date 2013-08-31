//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConcatenateTextFiles
{
    static void Main()
    {
        string contents1 = File.ReadAllText("../../Quote.txt");
        string contents2 = File.ReadAllText("../../Quote.txt");

        File.WriteAllText("../../outputFileName.txt", contents1 + '\n' + contents2);
        string readText = File.ReadAllText("../../outputFileName.txt");
        Console.WriteLine(readText);
    }
}

