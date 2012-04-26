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
            CodeAdd2N command = new CodeAdd2N();
            Console.Write("UITer's Software (version 1.0), Produced in 2012\n");
            do
            {
                
                Console.Write("\nYour command: ");
                command = new CodeAdd2N(Console.ReadLine());
                
                if (((command.Code.Length == 5) && (command.Code.Substring(0, 5)== command.Key) || ((command.Code.Length >= 6) && (command.Code.Substring(0, 6).CompareTo("Add2N ") == 0))))
                {
                    if (!command.Valid())
                    {
                        Console.WriteLine(command.ErrorMessage());
                    }
                    else
                    {
                        GreatInt n1 = new GreatInt(command.Number1());
                        GreatInt n2 = new GreatInt(command.Number2());
                        Console.WriteLine(n1.Number+" + "+n2.Number+" = "+(n1 + n2).Number);
                    }
                    
                }
                else
                {
                    if (command.Code == "exit")
                    {
                        exit = true;
                    }else
                        Console.WriteLine("System Message: Command's not found");
                }

                
            } while (exit == false);
            

            
        }
    }
}
