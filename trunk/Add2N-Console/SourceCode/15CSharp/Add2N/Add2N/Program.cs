using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {

            View _view;
            Logic _logic;
            string _number1 = "", _number2 = "";
            _view = new View();
            _logic = new Logic();
            if (args.Length < 2)
            {
                Console.WriteLine("Need 2 parameter");
                _view.In(ref _number1);
                _view.In(ref _number2);
            }
            else
            {
                _number1 = args[0];
                _number2 = args[1];
            }
            if (!_logic.Check(_number1) || !_logic.Check(_number2))
            {
                if (!_logic.Check(_number1)) Console.Write(_number1 + " ");
                if (!_logic.Check(_number1) && !_logic.Check(_number2)) Console.Write(", ");
                if (!_logic.Check(_number2)) Console.Write(_number2 + " ");
                Console.WriteLine("Is Wrong Format");
            }
            else Console.WriteLine(_number1 + " + " + _number2 + " = " + _logic.Add(_number1, _number2));
            Console.ReadLine();
        }
    }
}

