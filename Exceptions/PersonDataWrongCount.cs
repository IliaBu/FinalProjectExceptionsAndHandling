namespace FinalProjectExceptionsAndHandling.Exceptions
{
 /**
 * Класс исколючения - несоответствие количества значений.
 * Выбрасывается, если кол-во параметров в анализируемой строке не равно количеству полей класса PersonData
 */
    public class PersonDataWrongCount : PersonDataWrongException
    {
        public PersonDataWrongCount() :
          base("Количество переданных значений не соответствует количеству требуемых полей.")
        { }

        public PersonDataWrongCount(string message) :
            base(message)
        { }
    }
}
