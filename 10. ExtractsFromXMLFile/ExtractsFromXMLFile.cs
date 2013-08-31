//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
//<interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

class ExtractsFromXMLFile
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../XmlDoc.txt"))
        {
            char symbol;
            int index = reader.Read();
            symbol = (char)index;
            while (index != (-1))
            {
                if (symbol == '<')
                {
                    index = reader.Read();
                    symbol = (char)index;
                    Console.WriteLine();
                    while (symbol != '>')
                    {
                        index = reader.Read();
                        symbol = (char)index;
                    }
                }
                else
                {
                    Console.Write(symbol);
                }
                index = reader.Read();
                symbol = (char)index;
            }
            return;
        }
    }
}


