using System;
using System.Collections.Generic;
using System.IO;
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
                //Console.ForegroundColor = ConsoleColor.Black;
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
                        ShowAllFilesCurrentDirectory();
                        break;
                    case "-d":
                        ShowSubdirectoryCurrentDirectory();
                        break;
                    case "-h":
                        ShowHelp();
                        break;
                     default:
                        UnknownArgument();
                        break;
                }
            }
        }

        static void ShowCurrentDirectory()
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Current Directory:");

            Console.WriteLine(Environment.CurrentDirectory);
        }

        static void ShowAllFilesCurrentDirectory()
        {
            //Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("All files in current directory:");

            foreach (string file in Directory.GetFiles(Environment.CurrentDirectory))
            {
                Console.WriteLine(file);
            }
        }

        static void ShowSubdirectoryCurrentDirectory()
        {
            //Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("subdirectory in current Directory:");

            foreach (string SubDirectory in Directory.GetDirectories(Environment.CurrentDirectory))
            {
                Console.WriteLine(SubDirectory);
            }
        }
        
        static void ShowHelp()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("help: -c / -f / -d / -h");
        }

        static void UnknownArgument()
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Unknown Argument:");

            Console.WriteLine(Environment.CurrentDirectory);

            foreach (string file in Directory.GetFiles(Environment.CurrentDirectory))
            {
                Console.WriteLine(file);
            }
        }

    }
    
}
