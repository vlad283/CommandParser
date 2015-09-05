using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CommandParser
{
    class Program
    {
        private const string HELP1 = "/?";
        private const string HELP2 = "/help";
        private const string HELP3 = "-help";

        private const string K = "-k";

        private const string PING = "-ping";
        private const string PRINT = "-print";


        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                printHelp();
            }
            for (int i = 0; i < args.Length; i++)
            {
                
                bool flag = false;
                if (HELP1.Equals(args[i]) || HELP2.Equals(args[i]) || HELP3.Equals(args[i]))
                {
                    printHelp();
                }
                else if (K.Equals(args[i]))
                {
                    for (int y = i; y < args.Length - 1; )
                    {
                        string key = ++y < args.Length ? args[y] : "null";
                        string value = ++y < args.Length ? args[y] : "null";

                        Console.WriteLine(key + " - " + value);

                        i = y;
                    }
                }
                else if (PING.Equals(args[i]))
                {
                    Console.WriteLine("Pinging ...");
                    Console.Beep(2000, 1000);
                }
                else if (PRINT.Equals(args[i]))
                {
                    string message = ++i < args.Length ? args[i] : "null";
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Command <" + args[i] + "> is not supported, use CommandParser.exe /? to see set of allowed commands");
                }
            }

            Console.ReadLine();
        }
        public static void printHelp()
        {
            Console.WriteLine("CommandParser.exe [/?] [/help] [-help] [-k key value] [-ping] [-print <print a value>]");
        }
    }
}
