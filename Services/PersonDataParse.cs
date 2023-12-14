using FinalProjectExceptionsAndHandling.Exceptions;
using FinalProjectExceptionsAndHandling.Interfaces;
using System.Reflection;
using System.Text.RegularExpressions;

namespace FinalProjectExceptionsAndHandling.Services
{
    public class PersonDataParse : IDataParse<PersonData>
    {
        // Проверки элементов структуры данных
        // ФИО. Любые буквы кирилицы или латиницы, не менее 2х
        private static string NAME_PATTERN = "^[а-яА-Яa-zA-Z]{2,}$";
        // Телефонный номер. Набор любых цифр и знака + от 6 до 14
        private static string PHONE_PATTERN = "^\\+?[1-9][0-9]{6,14}$";
        // Пол. Любая из букв м или ж независимо от регистра
        private static string GENDER_PATTERN = "^[мжМЖ]$";
        // Дата рождения в формате dd.mm.yyyy
        private static string BIRTHDATE_PATTERN = "^[0-9]{1,2}\\.[0-9]{1,2}\\.[0-9]{4}$";

        // Проверки соответствия
        private Regex namePattern;
        private Regex phonePattern;
        private Regex genderPattern;
        private Regex birthDatePattern;

        public PersonDataParse(string namePattern, string phonePattern, string genderPattern, string birthDatePattern)
        {
            this.namePattern = new Regex(namePattern);
            this.phonePattern = new Regex(phonePattern);
            this.genderPattern = new Regex(genderPattern);
            this.birthDatePattern = new Regex(birthDatePattern);
        }

        public PersonDataParse() : this(NAME_PATTERN, PHONE_PATTERN, GENDER_PATTERN, BIRTHDATE_PATTERN)
        {}

        /// <summary>
        /// Парсинг строки в PersonData. В случае невозможности получения необходимой структуры данных
        /// выбрасывает исключение группы PersonDataWrongException
        /// </summary>
        /// <returns>- полученное значение</returns>
        public PersonData ParsePersonDate(string data)
        {
            string[] partsInfo = data.Split(" ");
            PersonData personData = new PersonData();

            // проверить соответствие количества параметров, при несоответствии -
            // выбросить соответствующее исключение PersonDataWrongCount
            int countValidate = this.IsPersonDataCountValid(partsInfo);
            if (countValidate < 0)
            {
                throw new PersonDataWrongCountLess();
            }
            else if (countValidate > 0)
            {
                throw new PersonDataWrongCountMore();
            }
            foreach (string s in partsInfo)
            {
                if (this.IsPersonNameValid(s))
                {
                    // Проверка на соответствие ФИО
                    // если совпадает - заполняем пустое значение
                    if (string.IsNullOrEmpty(personData.GetSurName()))
                    {
                        personData.SetSurName(s);
                    }
                    else if (string.IsNullOrEmpty(personData.GetFirstName()))
                    {
                        personData.SetFirstName(s);
                    }
                    else if (string.IsNullOrEmpty(personData.GetSecondName()))
                    {
                        personData.SetSecondName(s);
                    }
                } // Проверка на соответствие телефоному номеру
                else if (this.IsPersonPhoneValid(s))
                {
                    personData.SetPhone(s);
                } // Проверка на соответствие дате рождения
                else if (this.IsPersonBirthDateValid(s))
                {
                    personData.SetBirthDate(s);

                } // проверка на соответствие пола
                else if (this.IsPersonGenderValid(s))
                {
                    personData.SetGender(s.ToLower()); // сохраняем в нижний регистр
                }
            }

            // Проверим заполнение данными, если не все поля заполнены - выбасываем соответствующее исключение
            if (string.IsNullOrEmpty(personData.GetSurName()) || string.IsNullOrEmpty(personData.GetFirstName()) || string.IsNullOrEmpty(personData.GetSecondName()))
            {
                throw new NameWrongException();
            }

            if (string.IsNullOrEmpty(personData.GetPhone()))
            {
                throw new PhoneWrongException();
            }

            if (string.IsNullOrEmpty(personData.GetBirthDate()))
            {
                throw new BirthDateWrongException();
            }

            if (string.IsNullOrEmpty(personData.GetGender()))
            {
                throw new GenderWrongException();
            }
            return personData;
        }

        /// <summary>
        /// Парсинг строкового списка в ArrayList<PersonData>. Строки с неверным форматом игнорирует.
        /// Если валидных значений в переданном для обработки списке нет - вернет пустой ArrayList<PersonData>.
        /// </summary>
        /// <param name="data"> - список c исходной информацией</param>
        /// <returns> - список с полученных значений</returns>
        public List<PersonData> ParseListPersonData(List<string> data)
        {
            List<PersonData> list = new List<PersonData>();
            foreach (string s in data)
            {
                try
                {
                    list.Add(ParsePersonDate(s));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }

            return list;
        }

        /// <summary>
        /// Проверка количества переданных параметров. Возвращает код ошибки сравнения.
        /// </summary>
        /// <param name="parameters">- массив переаваемых пользователем параметров</param>
        /// <returns>             - код результата сравнения
        ///                         1 - передано больше чем нужно
        ///                        -1 - передано меньше чем нужно
        ///                         0 - количество верное</returns>
        private int IsPersonDataCountValid(string[] parameters)
        {
            FieldInfo[] myField = typeof(PersonData).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            if (myField.Length > parameters.Length)
            {
                return -1;
            }
            else if (myField.Length < parameters.Length)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Проверка строки на соответствие имени.
        /// </summary>
        /// <param name="name">- проверяемое значение</param>
        /// <returns> - результат проверки</returns>
        private bool IsPersonNameValid(string name)
        {
            return namePattern.IsMatch(name);
        }

        /// <summary>
        /// Проверка строки на соответствие телефонному номеру.
        /// </summary>
        /// <param name="number">- проверяемое значение</param>
        /// <returns> - результат проверки</returns>
        private bool IsPersonPhoneValid(string number)
        {
            return phonePattern.IsMatch(number);
        }

        /// <summary>
        /// Проверка строки на соответствие информации о половой принадлежности персоны.
        /// </summary>
        /// <param name="gender"> - проверяемое значение</param>
        /// <returns> - результат проверки</returns>
        private bool IsPersonGenderValid(string gender)
        {
            return genderPattern.IsMatch(gender);
        }

        /// <summary>
        /// Проверка строки на соответствие даты.
        /// </summary>
        /// <param name="birthDate">- проверяемое значение</param>
        /// <returns> - результат проверки</returns>
        private bool IsPersonBirthDateValid(string birthDate)
        {
            return birthDatePattern.IsMatch(birthDate);
        }

    }
}
