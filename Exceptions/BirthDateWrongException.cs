namespace FinalProjectExceptionsAndHandling.Exceptions
{
 /**
 * Класс исключения - неверный формат даты рождения.
 * Выбрасывается, если дата рождения не соответствует требуемому формату (дд.мм.гггг).
 * В качестве допустимых символов разрешены только цифры и точки в строго определенных местах
 */
    public class BirthDateWrongException : PersonDataWrongException
    {
        public BirthDateWrongException() :
           base("Неверный формат даты рождения. Вводите дату в формате дд.мм.гггг")
        { }

        public BirthDateWrongException(string message) :
            base(message)
        { }

    }
}
