using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PersonsLib
{
    /// <summary>
    /// Класс, описывающий человека
    /// </summary>
    public class Person
    {

        #region Поля и свойства
        /// <summary>
        /// Имя человека
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Свойство для поля "Имя"
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                CheckNameForCorrectness(value);
                _firstName = FirstLetterChangeToBig(value);
            }
        }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Свойство для поля "Фамилия"
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                CheckNameForCorrectness(value);
                _lastName = FirstLetterChangeToBig(value);
            }
        }

        /// <summary>
        /// Возраст человека
        /// </summary>
        private int _age;

        /// <summary>
        /// Свойство для поля "Возраст"
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be from 0 to 100");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Свойство для поля "пол"
        /// </summary>
        public SexTypes SexType { get; set; }
        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person() { }

        /// <summary>
        /// Конструктор для инициализации полей человека
        /// </summary>
        /// <param name="firstName">Имя человека</param>
        /// <param name="lastName">Фамилия человека</param>
        /// <param name="age">Возраст человека</param>
        /// <param name="gender">Пол человека</param>
        public Person(string firstName, string lastName, int age,
            SexTypes gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SexType = gender;
        }
        #endregion

        #region Проверки
        /// <summary>
        /// Проверка параметра на корректность написания
        /// </summary>
        /// <param name="input">Параметр для проверки</param>
        /// <returns>Параметр, приведенный к желаемому виду</returns>
        private static bool IsNameCorrect(string input)
        {
            var expressionForRegex = "(([А-Я]|[а-я]|[A-Z]|[a-z])+)";
            var regexForName = new Regex(
                $"^{expressionForRegex}((-)?){expressionForRegex}$");

            if (!regexForName.IsMatch(input))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка имени или фамилии на значение
        /// </summary>
        /// <param name="input">Параметр для проверки</param>
        private void CheckNameForCorrectness(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(
                    $"{nameof(input)} is null or empty.");
            }
            if (!IsNameCorrect(input))
            {
                throw new FormatException(
                    $"{nameof(input)} - only letters of Russian" +
                    $" or English alphabet.");
            }
        }
        #endregion

        #region Изменения
        /// <summary>
        /// Измененение первой буквы в имени или фамилии на заглавную
        /// с учетом "-"
        /// </summary>
        /// <param name="wordToChange">Строка для изменения</param>
        /// <returns>Обновленная строка</returns>
        private static string FirstLetterChangeToBig(string wordToChange)
        {
            string[] buffer = wordToChange.Split('-');
            wordToChange = null;

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = buffer[i].First().ToString().ToUpper() +
                    buffer[i].Substring(1);

                wordToChange += $"{buffer[i]}-";
            }

            return wordToChange.Substring(0, wordToChange.Length - 1);
        }
        #endregion

        #region Формирование информации
        /// <summary>
        /// Формирование информации о человеке
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public string InfoAboutPerson()
        {
            return $"{FirstName} {LastName}, " +
                $"Возраст: {Age}, Пол: {SexType}";
        } 
        #endregion
    }
}
