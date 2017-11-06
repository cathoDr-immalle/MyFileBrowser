using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyFileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "Dit is een test";
            if (args.Length == 0)
            {
                Console.WriteLine("Geef een argument!");
            }
            else
            {
                switch(args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllFilesCurrentDirecty();
                        break;
                    case "-d":
                        ShowSubdirectoryCurerntFile();
                        break;
                    default:
                        UnknownArgument();
                        break;
                    case "-h":
                        ShowHelp();
                        break;
                    case 
                }
            }
        }

        static void ShowCurrentDirectory()
        {
            Console.WriteLine(Environment.CurrentDirectory);
        }

        static void ShowAllFilesCurrentDirecty()
        {
           //onsole.WriteLine(Directory.GetFiles());
        }

        static void ShowSubdirectoryCurerntFile()
        {
            Console.WriteLine("subdirectory in current file");
        }

        static void UnknownArgument()
        {
            Console.WriteLine("Unknown argument");
        }

        static void ShowHelp()
        {
            Console.WriteLine("Show help");
        }

        static void Test()
        {
            if (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[if];
            }
        }
    }
}
