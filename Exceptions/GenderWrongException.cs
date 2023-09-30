﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectExceptionsAndHandling.Exceptions
{
    /**
    * Класс исключения - неверный формат пола.
    * Выбрасывается, если пол указан с использованием недопустимых символов.
    */
    public class GenderWrongException : PersonDataWrongException
    {
        public GenderWrongException() :
            base("Пол персоны указан неверно. Вводите английские буквы m или f")
        { }

        public GenderWrongException(string message) :
            base(message)
        { }
    }
}
