using FinalProjectExceptionsAndHandling.Exceptions;

namespace FinalProjectExceptionsAndHandling.Interfaces
{
  /**
  * Интерфейс для парсинга текстовой информации в формат PersonData
  */
    public interface IDataParse<E>
    {
        /**
         * Парсинг строки в <E>. В случае невозможности получения необходимой структуры данных
         * выбрасывает исключение группы PersonDataWrongException
         *
         * @param data  - строка для анализа и парсинга
         * @return      - полученное значение
         */
        E ParsePersonDate(string data) { 
            throw new PersonDataWrongException(); 
        }
        /**
         * Парсинг строкового списка в ArrayList<E>. Строки с неверным форматом игнорирует.
         * Если валидных значений в переданном для обработки списке нет - вернет пустой ArrayList<E>.
         *
         * @param data  - список c исходной информацией
         * @return      - список с полученных значений
         */
        List<E> ParseListPersonData(List<string> data);

    }

}
