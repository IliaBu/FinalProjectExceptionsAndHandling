using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectExceptionsAndHandling.Exceptions
{
/**
* Класс исключения - несоответствие количества параметров.
* Выбрасывается, если кол-во параметров в анализируемой строке больше количества полей класса PersonData
*/
    public class PersonDataWrongCountMore : PersonDataWrongException
    {
        public PersonDataWrongCountMore() :
            base("Количество переданных параметров превышает необходимое!")
        { }

        public PersonDataWrongCountMore(string message) :
            base(message)
        { }
    }
}