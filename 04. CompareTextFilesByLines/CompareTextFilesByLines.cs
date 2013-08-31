//Write a program that compares two text files line by line and prints the number of lines that are the same 
//and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class CompareTextFilesByLines
{
    static void Main()
    {

        CompareFiles("../../LedZeppelin_v1.txt", "../../LedZeppelin_v2.txt");
    }

    static void CompareFiles(string firstFile, string secondFile)
    {
        int numberSameLines = 0;
        int numberDifferentLines = 0;
        // int lineNumber = 0;
        string lineFirstFile;
        string lineSecondFile;
        using (StreamReader readerFirstFile = new StreamReader(firstFile))
        {
            using (StreamReader readerSecondFile = new StreamReader(secondFile))
            {

                lineFirstFile = readerFirstFile.ReadLine();
                lineSecondFile = readerSecondFile.ReadLine();
                while ((lineFirstFile != null) || (lineSecondFile != null))
                {
                    if (lineFirstFile == lineSecondFile)
                    {
                        numberSameLines++;
                    }
                    else
                    {
                        numberDifferentLines++;
                    }
                    lineFirstFile = readerFirstFile.ReadLine();
                    lineSecondFile = readerSecondFile.ReadLine();
                }
            }
        }
        Console.WriteLine("Number of same lines is {0}, number of different lines is {1}.", numberSameLines, numberDifferentLines);
    }
}