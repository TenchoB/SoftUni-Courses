﻿using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favariteBook = Console.ReadLine();
            int counter = 0;
            bool isbookfound = false;
            string nextBookName = Console.ReadLine();
            while (nextBookName != "No More Books" )
            {
                if (nextBookName == favariteBook)
                {
                    isbookfound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();

            }
            if (isbookfound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}