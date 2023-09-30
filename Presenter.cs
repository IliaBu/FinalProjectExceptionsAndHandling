using FinalProjectExceptionsAndHandling.Exceptions;
using FinalProjectExceptionsAndHandling.Interfaces;
using FinalProjectExceptionsAndHandling.Services;
using System;

namespace FinalProjectExceptionsAndHandling
{
    /// <summary>
    /// Инициализирует новый экземпляр класса Presenter
    /// Объединяет в работу пользовательский интерфейс, парсер строки, проверку на валидность элементов строки
    /// Пишет в текстовые файлы инфо по заданному формату.
    /// </summary>
    /// <param name="dataPath"> - путь для сохранения текстового файла</param>
    /// <param name="dataParse"> - парсер строки и проверка элементов на валидность</param>
    /// <param name="dataSave"> - пишет в файл согласно условию</param>
    /// <param name="dataList"> - добавляет данные в список</param>
    public class Presenter
    {
        private static string dataPath = "";
        private PersonDataParse dataParse = new PersonDataParse();
        private PersonDataSave dataSave = new PersonDataSave(dataPath);
        private PersonDataList dataList = new PersonDataList();


        /// <summary>
        /// Вывод лог информации и сообщений пользователю
        /// </summary>
        /// <param name="message"> - выводимое сообщение</param>
        private void LogInfo(string message)
        {
            Console.WriteLine(message + "\n");
        }

        public void run()
        {
            try
            {
                string data = string.Empty;
                ConsoleKeyInfo info;
                while(true)
                {
                    Console.WriteLine("\nВведите Фамилию Имя Отчество ДатуРождения НомерТелефона Пол через пробел:");
                    data = Console.ReadLine();
                    PersonData personData = dataParse.ParsePersonDate(data);
                    dataList.Append(personData);
                    dataSave.SaveDataToFile(personData);

                    Console.WriteLine("\nНажмите Escape для выхода, либо Enter для добавления ещё одного человека");
                    info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
            catch (PersonDataWrongException e) {         
                LogInfo(e.Message.ToString());
            } 
            catch (IOException e) {
                LogInfo(e.Message.ToString());
            }
            catch (Exception e)
            {
                LogInfo(e.Message.ToString());
            }
        }
    }
}
