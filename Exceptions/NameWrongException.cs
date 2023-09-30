using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectExceptionsAndHandling.Exceptions
{
    /**
     * Класс исключения - неверные персональные данные.
     * Выбрасывается, если веденные ФИО содержат недопустимые символы.
     * В качестве допустимых символов разрешены латинские или кириллические буквы и дефис
     */
    public class NameWrongException : PersonDataWrongException
    {
        public NameWrongException() :
            base("Неверный формат Фамилии, Имени или Отчества. Разрешены латинские или кириллические буквы и дефис")
        { }

        public NameWrongException(string message) :
            base(message)
        { }
    }
}
