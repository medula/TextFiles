//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
//Example:
//	Ivan			George
//	Peter			Ivan
//	Maria			Maria
//	George			Peter

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class SortListOfStrings
{
    static void Main()
    {
        List<string> listStrings = ConvertTextFileStringsToList("../../FileOfStrings.txt");
        listStrings.Sort();
        WriteStringArrayToFile(listStrings);
        PrintTextFile("../../outputFile.txt");
    }
    static List<string> ConvertTextFileStringsToList(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            List<string> array = new List<string>();
            string line = reader.ReadLine();
            int index = 0;
            while (line != null)
            {
                array.Add(line);
                line = reader.ReadLine();
                index++;
            }
            return array;
        }
    }
    static void WriteStringArrayToFile(List<string> listStrings)
    {
        using (StreamWriter writer = new StreamWriter("../../outputFile.txt"))
        {
            for (int index = 0; index < listStrings.Count; index++)
            {
                writer.WriteLine(listStrings[index]);
            }
        }
    }
    static void PrintTextFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine("{0}", line);
                line = reader.ReadLine();
            }
        }
    }
}

