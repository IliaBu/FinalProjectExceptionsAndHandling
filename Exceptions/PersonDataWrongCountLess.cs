namespace FinalProjectExceptionsAndHandling.Exceptions
{
/**
* Класс исколючения - несоответствие количества параметров.
* Выбрасывается, если кол-во параметров в анализируемой строке меньше количества полей класса PersonData
*/
    public class PersonDataWrongCountLess : PersonDataWrongException
    {
        public PersonDataWrongCountLess() :
          base("Количество переданных параметров меньше необходимого.")
        { }

        public PersonDataWrongCountLess(string message) :
            base(message)
        { }
    }
}
