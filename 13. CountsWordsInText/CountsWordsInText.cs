//Write a program that reads a list of words from a file words.txt and finds how many times each of the words 
//is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted
//by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Text.RegularExpressions;

class CountsWordsInText
{
    static void Main()
    {
        try
        {
            string file = "../../words.txt";
            string text = "../../test.txt";
            string result = "../../result.txt";
            string[] arrayWords = ConvertTextFileToArray(file);
            int[] counts = new int[arrayWords.Length];
            using (StreamReader reader = new StreamReader(text))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < arrayWords.Length; i++)
                    {
                        string word = arrayWords[i];
                        counts[i] = CountWord(file, word);
                    }
                    line = reader.ReadLine();
                }
            }
            Array.Sort(counts, arrayWords);
            WriteResultInFile(result, arrayWords);
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
    static string[] ConvertTextFileToArray(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line = reader.ReadLine();
            string[] members = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] words = new string[members.Length];
            for (int i = 0; i < members.Length; i++)
            {
                words[i] = members[i];
            }
            return words;
        }
    }
    static int CountWord(string file, string word)
    {
        int count = 0;
        using (StreamReader reader = new StreamReader(file))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                MatchCollection matches = Regex.Matches(line, word);
                count = matches.Count;
                line = reader.ReadLine();
            }
        }
        return count;
    }
    static void WriteResultInFile(string file, string[] array)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            for (int index = 0; index < array.Length; index++)
            {
                writer.WriteLine(array[index]);
            }
        }
    }
}




