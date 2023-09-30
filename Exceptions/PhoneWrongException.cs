using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectExceptionsAndHandling.Exceptions
{
    /**
    * Класс исключения - неверный телефонный номер.
    * Выбрасывается, если введенный номер телефона содержит неверный формат.
    * В качестве допустимых символов разрешены только цифры и знак +
    */
    public class PhoneWrongException : PersonDataWrongException
    {
        public PhoneWrongException() :
            base("Телефонный номер имеет неверный формат. Используйте только цифры длиной от 7 до 14, знак + ")
        { }

        public PhoneWrongException(string message) :
            base(message)
        { }
    }
}
