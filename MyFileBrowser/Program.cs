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
                    
                }
            }
        }

        static void ShowCurrentDirectory()
        {
            Console.WriteLine("Current directory");
        }

        static void ShowAllFilesCurrentDirecty()
        {
            Console.WriteLine("All files in current directory");
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

    }
}
