using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _39_ADD2N
{
    /// <summary>
    ///  use class AddNumber to add 2 strings what use define ADD2N string1 string2 
    ///
    /// </summary>
    class Program
    {
        //Trinh Duy Thanh
        static void Main()
        {
            Console.WriteLine("Example: ADD2N 1111 2222 \nReSult: 1111 + 2222= 3333 ");
            Console.WriteLine("Input Your String Here:  ");
            string strInput = Console.ReadLine();
            string[] strSplitInput;
            strSplitInput = strInput.Split(' ');
            AddNumber Add = new AddNumber();
            if (Add.IsValid(strSplitInput[1]) && Add.IsValid(strSplitInput[2]))
            {
                Console.WriteLine();
                Console.WriteLine("{0} + {1} = {2}", strSplitInput[1], strSplitInput[2], Add.AddTwoStrings(strSplitInput[1],
                                                                                                            strSplitInput[2]));
            }
            else
            {
                if (!Add.IsValid(strSplitInput[1]) && !Add.IsValid(strSplitInput[2]))
                {
                    Console.WriteLine("{0} {1} are not valid string", strSplitInput[1], strSplitInput[2]);
                }
                else
                {
                    if (!Add.IsValid(strSplitInput[1]))
                    {
                        Console.WriteLine("{0} is not valid string", strSplitInput[1]);
                    }
                    if (!Add.IsValid(strSplitInput[2]))
                    {
                        Console.WriteLine("{0} is not valid string", strSplitInput[2]);
                    }
                }

            }
            Console.ReadLine();

        }
    }
}
