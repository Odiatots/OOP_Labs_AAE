﻿using System;

namespace PersonsLib
{
    /// <summary>
    /// Класс, описывающий взрослого человека
    /// </summary>
    public class Adult : PersonBase
    {
        #region Константы

        /// <summary>
        /// Минимальный возраст взрослого
        /// </summary>
        public const int MINAGE = 18;

        /// <summary>
        /// Максимальный возраст взрослого
        /// </summary>
        public const int MAXAGE = 100;

        #endregion

        #region Поля и Свойства

        /// <summary>
        /// Возраст взрослого
        /// </summary>
        public override int Age
        {
            get { return base.Age; }
            set
            {
                if (value < MINAGE || value > MAXAGE)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be from " +
                        $"{MINAGE} to {MAXAGE}.");
                }
                base.Age = value;
            }
        }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        private string _passportNumber;

        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string PassportNumber
        {
            get { return _passportNumber; }
            set
            {
                CheckingPassportDataForValues(value, 6);
                _passportNumber = value;
            }
        }

        /// <summary>
        /// Серия паспорта
        /// </summary>
        private string _passportSerial;

        /// <summary>
        /// Серия паспорта
        /// </summary>
        public string PassportSerial
        {
            get { return _passportSerial; }
            set
            {
                CheckingPassportDataForValues(value, 4);
                _passportSerial = value;
            }
        }

        /// <summary>
        /// Состояние брака
        /// </summary>
        public MarriageStatus MarriageStatus { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Партнер
        /// </summary>
        public Adult Partner
        {
            get { return _partner; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        $"{nameof(Partner)}", $"{nameof(Partner)} value is" +
                        " null!");
                }

                if (MarriageStatus == MarriageStatus.Married &&
                    value.MarriageStatus == MarriageStatus.Married)
                {
                    _partner = value;
                }
                else
                {
                    throw new ArgumentException(
                        "One of adults cannot have partners! " +
                        "Please check marital statuses!");
                }
            }
        }

        /// <summary>
        /// Место работы
        /// </summary>
        public string PlaceOfWork { get; set; }

        #endregion

        #region Методы

        /// <summary>
        /// Проверка серии/номера паспорта на корректность значений
        /// </summary>
        /// <param name="value">Серия/номер паспорта</param>
        /// <param name="digitsAmount">Количество цифр в серии/номере</param>
        private void CheckingPassportDataForValues(string value,
            byte numberOfDigits)
        {
            if (value.Length != numberOfDigits)
            {
                throw new ArgumentException(
                    $"{nameof(value)} must contain exactly " +
                    $"{numberOfDigits} digits.");
            }

            if (!int.TryParse(value, out _))
            {
                throw new FormatException(
                    $"{nameof(value)} must be a number.");
            }
        }

        /// <summary>
        /// Посмотреть телек
        /// </summary>
        /// <returns>Смотрит телек</returns>
        public string WatchTV()
        {
            return $" {ShortInfoAboutPerson()} идет залипать в телек.";
        }

        /// <summary>
        /// Определение взрослого
        /// </summary>
        /// <returns>Взрослый</returns>
        public override string WhoAmI()
        {
            return "Я - взрослый человек.";
        }

        #endregion

        #region Формирование информации

        /// <summary>
        /// Сформировать информацию о взрослом
        /// </summary>
        /// <returns>Информация о взрослом</returns>
        public override string InfoAboutPerson()
        {
            string statusOfMarriage;

            switch (MarriageStatus)
            {
                case MarriageStatus.Single:
                    if (SexType == SexTypes.Female)
                        statusOfMarriage = "Не замужем";
                    else
                        statusOfMarriage = "Не женат";
                    break;
                case MarriageStatus.Married:
                    if (SexType == SexTypes.Female)
                        statusOfMarriage = "Замужем";
                    else
                        statusOfMarriage = "Женат";
                    break;
                case MarriageStatus.Widowed:
                    if (SexType == SexTypes.Female)
                        statusOfMarriage = "Вдова";
                    else
                        statusOfMarriage = "Вдовец";
                    break;
                case MarriageStatus.Separated:
                    if (SexType == SexTypes.Female)
                        statusOfMarriage = "Отделена";
                    else
                        statusOfMarriage = "Отделен";
                    break;
                case MarriageStatus.Divorced:
                    if (SexType == SexTypes.Female)
                        statusOfMarriage = "Разведена";
                    else
                        statusOfMarriage = "Разведен";
                    break;
                default:
                    if (SexType == SexTypes.Female)
                        statusOfMarriage = "Неизвестно";
                    else
                        statusOfMarriage = "Неизвестно";
                    break;

            }

            var infoAboutPerson = base.InfoAboutPerson() +
                $"\nСерия/номер паспорта: {PassportSerial} " +
                $"{PassportNumber}\nСемейное положение: {statusOfMarriage}";

            if (MarriageStatus == MarriageStatus.Married)
            {
                infoAboutPerson += $", Партнер: {Partner.FirstName} " +
                    $"{Partner.LastName}";
            }

            infoAboutPerson += "\nМесто работы: ";

            if (string.IsNullOrEmpty(PlaceOfWork))
            {
                infoAboutPerson += "Самозанятый (тунеядец)";
            }
            else
            {
                infoAboutPerson += PlaceOfWork;
            }

            return infoAboutPerson;
        }

        #endregion

    }
}
