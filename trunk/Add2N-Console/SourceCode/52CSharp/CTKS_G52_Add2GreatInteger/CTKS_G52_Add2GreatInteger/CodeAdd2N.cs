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
        public string Code { get; set; }
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
            int space = 0;
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i] == ' ')
                {
                    space++;
                }
            }
            //Wrong if KeyWord isn't "Add2N"
            if (Code.Remove(6) != "Add2N ")
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



            int head = Code.IndexOf(" ") + 1; //vị trí kí tự đầu của chuỗi số 1(đứng sau space thứ 1)
            int tail = Code.IndexOf(" ", head); //vị trí cuối của chuỗi số 1 (đứng trước space thứ 2)


            return Code.Substring(head, tail - head);
        }

        //Get number 2
        public string Number2()
        {





            int head = Code.IndexOf(" ", Code.IndexOf(" ") + 1) + 1;

            int tail = Code.Length;

            return Code.Substring(head, tail - head);
        }
    }
}
