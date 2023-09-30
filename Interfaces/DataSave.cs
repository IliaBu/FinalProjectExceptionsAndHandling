using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectExceptionsAndHandling.Interfaces
{
    /// <summary>
    /// Сохранение информации о людях в файл
    /// </summary>
    public interface IDataSave<E>
    {
        /// <summary>
        /// Сохранние структуры PersonData в текстовый файл. В качестве имени файла используется значение lastName
        /// </summary>
        /// <param name="data"> - структура для сохранения</param>
        /// <returns> - результат выполнения операции</returns>
        void SaveDataToFile(E data);
    }
}
