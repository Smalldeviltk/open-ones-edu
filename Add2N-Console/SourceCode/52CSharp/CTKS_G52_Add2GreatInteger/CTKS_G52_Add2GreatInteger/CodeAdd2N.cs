using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTKS_GreatInteger
{
    struct Error
    {
        bool KeyWord;
        bool Space;
        bool Num1;
        bool Num2;
        bool NoError;
    }
    class CodeAdd2N
    {
        public string Code { get; set;}
        public bool Valid { get; set; }
        //constructor
        public CodeAdd2N()
        {
            Code = "Add2N 1 1";
            Valid = true;

        }
        public CodeAdd2N(string _Code)
        {
            Code = _Code;

        }


        //Valid or Invalid
        public string GetError()
        {
            int space=0;
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i] == ' ')
                {
                    space++;
                }
            }
            //Wrong if KeyWord isn't "Add2N"
            if(Code.Remove(6)!="Add2N ")
            {
                return "KeyWord";
            }
            //wrong if the other 2 spacious
            if (space != 2)
            {
                return "Space";
            }
                return "Right";
        }

        //Get number 1
        public string Number1()
        {
            string s="";
            for (int i = 6; Code[i]!=' '; i++)
            {
                s += Code[i];
            }

            return s;
        }
        //Get number 2
        public string Number2()
        {
            string rs = "";
            for (int i = Code.Length-1; Code[i] != ' '; i--)
            {
                rs += Code[i];
            }
            string s="";
            for (int i = rs.Length - 1; i >= 0; i--)
            {
                s += rs[i];
            }
            
            return s;
        }

    


    }
}
