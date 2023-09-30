namespace FinalProjectExceptionsAndHandling.Exceptions
{
 /**
 * Класс исключений обработчика пользовательского ввода.
 */
    public class PersonDataWrongException : Exception
    {
        public PersonDataWrongException() :
            base("Персональные данные не распознаны или имеют неверный формат!")
        { }

        public PersonDataWrongException(string message) :
            base(message)
        { }

    }
}
