using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CTKS_GreatInteger
{
    public struct Add2NError
    {
        public bool KeyWord;
        public bool Num1;
        public bool Num2;
        public bool AllNum;
        public bool NoError;
    }
    class CodeAdd2N
    {
        public string Code { get; set; }
        public static string Key { get { return "Add2N"; } }//keyword giup nhan dien loai command

        

        //constructor
        public CodeAdd2N()
        {
            Code = "Add2N 1 1";

        }
        public CodeAdd2N(string _Code)
        {
            Code = _Code;

        }



        //Get number 1 (wrong or right)
        private string GetNumber1()
        {
            int head = Code.IndexOf(" ") + 1; //vị trí kí tự đầu của chuỗi số 1(đứng sau space thứ 1)
            int tail = Code.IndexOf(" ", head); //vị trí cuối của chuỗi số 1 (đứng trước space thứ 2)
            return Code.Substring(head, tail - head);
        }

        //Get number 2 (wrong or right)
        private string GetNumber2()
        {
            int head = Code.IndexOf(" ", Code.IndexOf(" ")+1) + 1;
            int tail = Code.Length;
            string s = Code.Substring(head, tail - head);
            return Code.Substring(head, tail - head);
            
        }


        

        //get Error type
        public Add2NError ErrorType()
        {
            Add2NError Error = new Add2NError();


            //wrong if the other 2 spacious
            int space = 0;
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i] == ' ')
                {
                    space++;
                }
            }
            if (space != 2||Code.Substring(0,6)!="Add2N ")
            {
                Error.KeyWord = true;
            }
            else
            {
                //Number 1 is wrong
                string num1 = GetNumber1();
                for (int i = 0; i < num1.Length; i++)
                {
                    if ((num1[i] < '0') || (num1[i] > '9'))
                    {
                        Error.Num1 = true;
                    }
                }

                //Number 2 is wrong
                string num2 = GetNumber2();
                for (int i = 0; i < num2.Length; i++)
                {
                    if ((num2[i]<'0')||(num2[i]>'9'))
                    {
                        Error.Num2 = true;
                    }
                }
                
            }
            if (Error.Num1 && Error.Num2)
            {
                Error.AllNum = true;
            }
            if((!Error.KeyWord)&&(!Error.Num1)&&(!Error.Num2)&&(!Error.AllNum))
            {
                Error.NoError = true;
            }

                return Error;
        }

        //the code Wrong or Right
        public bool Valid()
        {
            return  ErrorType().NoError;
        }

        //get Error Message
        public string ErrorMessage()
        {          
            //KeyWord is wrong
            if (ErrorType().KeyWord)
            {
                return "Wrong Form! Right form of command: Add2N <number1> <number2>";
            }

            //wrong if the other 2 spacious
            if (ErrorType().AllNum)
            {
                

                return GetNumber1() + " ," + GetNumber2() + " is invalid";
            }
            else
            {
                if (ErrorType().Num1)
                {
                    
                    return GetNumber1() + " is invalid";
                }
                if (ErrorType().Num2)
                {
                    
                    return GetNumber2() + " is invalid";
                }
            }


            return "Right";
        }


        //Get number 1
        public string Number1()
        {
            if(!Valid())
            {
                return "0";
            }
            else
            {
                int head = Code.IndexOf(" ") + 1; //vị trí kí tự đầu của chuỗi số 1(đứng sau space thứ 1)
                int tail = Code.IndexOf(" ", head); //vị trí cuối của chuỗi số 1 (đứng trước space thứ 2)
                return Code.Substring(head, tail - head);
            }
        }
        //Get number 2
        public string Number2()
        {
            if (!Valid())
            {
                return "0";
            }
            else
            {
                int head = Code.IndexOf(" ", Code.IndexOf(" ") + 1) + 1;
                int tail = Code.Length;
                return Code.Substring(head, tail - head);
            }
        }    
     
    }
}
