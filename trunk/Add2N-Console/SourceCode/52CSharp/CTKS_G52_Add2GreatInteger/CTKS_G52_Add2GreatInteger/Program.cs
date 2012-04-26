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
            Console.Write("UITer's Software (version 1.0), Produced in 2012\n");
            do
            {
                
                Console.Write("\nYour command: ");
                command = Console.ReadLine();
                
                if (((command.Length == 5) && (command.Substring(0, 5)== CodeAdd2N.Key) || ((command.Length >= 6) && (command.Substring(0, 6) == (CodeAdd2N.Key+" ")))))
                {
                    CodeAdd2N comAdd2N = new CodeAdd2N(command);
                    if (!comAdd2N.Valid())
                    {
                        Console.WriteLine(comAdd2N.ErrorMessage());
                    }
                    else
                    {
                        GreatInt n1 = new GreatInt(comAdd2N.Number1());
                        GreatInt n2 = new GreatInt(comAdd2N.Number2());
                        Console.WriteLine(n1.Number+" + "+n2.Number+" = "+(n1 + n2).Number);
                    }
                    
                }
                else
                {
                    if (command == "exit")
                    {
                        exit = true;
                    }else
                        Console.WriteLine("System Message: Command's not found");
                }

                
            } while (exit == false);
            

            
        }
    }
}
