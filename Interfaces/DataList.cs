namespace FinalProjectExceptionsAndHandling.Interfaces
{
    /// <summary>
    /// Компонент, реализующий управлениеи коллекцией данных
    /// </summary>
    public interface IDataList<E>
    {
        /// <summary>
        /// Добавление элемента в коллекцию
        /// </summary>
        /// <param name="item">- добавляемые данные</param>
        void Append(E item);
        /// <summary>
        /// Удалениеи элемента из коллекции
        /// </summary>
        /// <param name="item">- удаляемый элемент</param>
        void Delete(E item);
        /// <summary>
        /// Получение элемента из коллекции по индексу
        /// </summary>
        /// <param name="index">- индекс возвращаемого документа</param>
        /// <returns></returns>
        E Get(int index);
        /// <summary>
        /// Получение списка данных
        /// </summary>
        /// <returns></returns>
        List<E> GetList();
    }
}
