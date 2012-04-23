using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    partial class Calculator
    {
        /* Ham kiem tra 2 chuoi nguoi dung nhap vao co hop le hay khong
         * su dung ham CheckInput de kiem tra tung chuoi */
        public bool CanAdd(String a, String b)
        {
            if (CheckInput(a))
            {
                if (!CheckInput(b))
                {
                    /*Truong hop a hop le va b khong hop le*/
                    this.ErrorMessage = b + " khong hop le.";
                    return false;
                }
                else
                {
                    /* Ca 2 deu hop le */
                    this.ErrorMessage = "OK";
                    return true;
                }
            }
            else
            {
                if (!CheckInput(b))
                {
                    /* Ca hai deu khong hop le */
                    this.ErrorMessage = a + ", " + b + " khong hop le.";
                    return false;
                }
                else
                {
                    /* a khong hop le */
                    this.ErrorMessage = a + " khong hop le";
                    return false;
                }
            }

        }
    }
}
