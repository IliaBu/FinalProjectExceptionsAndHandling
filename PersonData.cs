namespace FinalProjectExceptionsAndHandling
{
    /**
     * Структура пользовательских данных
     */

    public class PersonData
    {
        // Фамилия
        public string lastName;
        // Имя
        public string firstName;
        // Отчество
        public string secondName;
        // Телефон
        public string phone;
        // Дата рождения
        public string birthDate;
        // Пол
        public string gender;


        public PersonData() : this("", "", "", "", null, "")
        {}

        public PersonData(string lastName, string firstName, string secondName, string phone, string birthDate, string gender)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.secondName = secondName;
            this.phone = phone;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public string SurNameProperty()
        {
            return lastName;
        }

        public string FirstNameProperty()
        {
            return firstName;
        }

        public string SecondNameProperty()
        {
            return secondName;
        }

        public string PhoneProperty()
        {
            return phone;
        }

        public string BirthDateProperty()
        {
            return birthDate;
        }

        public string GenderProperty()
        {
            return gender;
        }

        public override string ToString()
        {
            return "<" + lastName + ">" +
                    "<" + firstName + ">" +
                    "<" + secondName + ">" +
                    "<" + birthDate + ">" +
                    "<" + phone + ">" +
                    "<" + gender + ">";
        }

        public string GetSurName()
        {
            return lastName;
        }

        public void SetSurName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetSecondName()
        {
            return secondName;
        }

        public void SetSecondName(string secondName)
        {
            this.secondName = secondName;
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public string GetBirthDate()
        {
            return birthDate;
        }

        public void SetBirthDate(string birthDate)
        {
            this.birthDate = birthDate;
        }

        public string GetGender()
        {
            return gender;
        }

        public void SetGender(string gender)
        {
            this.gender = gender;
        }
    }
}
