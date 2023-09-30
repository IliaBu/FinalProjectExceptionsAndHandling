using FinalProjectExceptionsAndHandling.Interfaces;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProjectExceptionsAndHandling.Services
{
    public class PersonDataSave : IDataSave<PersonData>
    {
        private string dataPath = "";

        public PersonDataSave()
        {}

        public PersonDataSave(string path)
        {
            this.dataPath = path;
        }

        /// <summary>
        /// Сохранение структуры в текстовый файл. В качестве имени используется фамилия персоны.
        /// </summary>
        /// <param name="data">- структура для сохранения</param>
        /// <exception cref="IOException"></exception>
        public void SaveDataToFile(PersonData data)
        {
            try
            {
                string fileName = dataPath + data.GetSurName() + ".txt";
                using (StreamWriter file = new StreamWriter(fileName, true, Encoding.UTF8))
                {
                    file.WriteLine(data.ToString());
                    Console.WriteLine("Данные успешно записаны в файл " + fileName);
                }
            } catch (IOException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
