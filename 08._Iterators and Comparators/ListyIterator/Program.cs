﻿using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            ListyIterator<string> listyIterator = null;

            

            while (command != "END")
            {
                try
                {
                    if (command.Contains("Create"))
                    {
                        var items = command.Split().Skip(1).ToList();
                        listyIterator = new ListyIterator<string>(items);
                    }
                    else if (command == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (command == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (command == "PrintAll")
                    {
                        foreach (var item in listyIterator)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
                
                command = Console.ReadLine();
            }
        }
    }
}
