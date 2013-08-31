//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Text.RegularExpressions;

class DeletesGivenWords
{
    static void Main()
    {
        try
        {
            string file = "../../WordsToRemove.txt";
            List<string> arrayWords = ConvertTextFileToList(file);

            string text = "../../OriginalText.txt";
            string result = "../../OutputFile.txt";
            using (StreamReader reader = new StreamReader(text))
            {
                using (StreamWriter writer = new StreamWriter(result))
                {
                    string line = reader.ReadLine();
                    string newLine="";
                    while (line != null)
                    {
                        for (int i = 0; i < arrayWords.Count; i++)
                        {
                            string word = arrayWords[i];
                            newLine = line.Replace(word, "");
                            line = newLine;
                        }
                        writer.WriteLine(newLine);
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }

    }
    static List<string> ConvertTextFileToList(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line = reader.ReadLine();
            List<string> words = new List<string>();
            string[] members = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < members.Length; i++)
            {
                words.Add(members[i]);
            }
            return words;
        }
    }
}



