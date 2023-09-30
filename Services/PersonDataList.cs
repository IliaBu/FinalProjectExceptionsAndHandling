using FinalProjectExceptionsAndHandling.Interfaces;

namespace FinalProjectExceptionsAndHandling.Services
{
    public class PersonDataList : IDataList<PersonData>
    {
        private List<PersonData> dataList = new List<PersonData>();
        /// <summary>
        /// Добавление элемента в коллекцию
        /// </summary>
        /// <param name="item">- добавляемые данные</param>
        public void Append(PersonData item)
        {
            dataList.Add(item);
        }

        /// <summary>
        /// Удалениеи элемента из коллекции
        /// </summary>
        /// <param name="item">- удаляемый элемент</param>
        public void Delete(PersonData item)
        {
            dataList.Remove(item);
        }


        /// <summary>
        /// Получение элемента из коллекции по индексу
        /// </summary>
        /// <param name="index">- индекс возвращаемого документа</param>
        /// <returns></returns>
        public PersonData Get(int index)
        {
            return dataList[index];
        }

        /// <summary>
        /// Получение списка данных
        /// </summary>
        /// <returns></returns>
        public List<PersonData> GetList()
        {
            return dataList;
        }

    }
}
