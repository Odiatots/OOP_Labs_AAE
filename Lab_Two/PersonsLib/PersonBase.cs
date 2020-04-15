﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PersonsLib
{
    //TODO: RSDN - именование - исправлено
    /// <summary>
    /// Класс, описывающий человека
    /// </summary>
    public abstract class PersonBase
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
        public virtual int Age
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

        //TODO: Не используется (был стандартный конструктор) - исправлено
        //TODO: Не используется (был конструктор с параметрами) - исправлено

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

            return regexForName.IsMatch(input);
            //TODO: можно просто return regexForName.IsMatch(input); вместо всего что ниже - исправлено
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
            //TODO: Небезопасно, лучше сделать пустой строкой - исправлено
            wordToChange = string.Empty;

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
        public virtual string InfoAboutPerson()
        {
            return $"{FirstName} {LastName}, " +
                $"Возраст: {Age}, Пол: {SexType}";
        }

        /// <summary>
        /// Формирование короткой информации о человеке
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public string ShortInfoAboutPerson()
        {
            return $"{FirstName} {LastName}";
        }

        #endregion
    }
}