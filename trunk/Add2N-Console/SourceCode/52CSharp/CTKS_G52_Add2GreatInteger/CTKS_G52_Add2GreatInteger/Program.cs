using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CTKS_GreatInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string command = "";
            do
            {
                Console.Write("Your command: ");
                command = Console.ReadLine();


                if (((command.Length == 5) && (command.Substring(0, 5).CompareTo("Add2N") == 0)) || ((command.Length >= 6) && (command.Substring(0, 6).CompareTo("Add2N ") == 0)))
                {
                    //do sonething;
                    Console.WriteLine(command.Substring(0, 5));
                }
                else
                {
                    if (command == "exit")
                    {
                        exit = true;
                    }else
                        Console.WriteLine("System Message: Command not found\n");
                }

                
            } while (exit == false);
            

            
        }
    }
}
