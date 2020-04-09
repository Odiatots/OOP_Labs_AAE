using System;

namespace PersonsLib
{
    /// <summary>
    /// Класс, описывающий ребенка
    /// </summary>
    public class Child : Person
    {
        #region Константы

        /// <summary>
        /// Минимальный возраст ребенка
        /// </summary>
        public const int MINAGE = 0;

        /// <summary>
        /// Максимальный возраст ребенка
        /// </summary>
        public const int MAXAGE = 17;

        #endregion

        #region Поля и Свойства

        /// <summary>
        /// Возраст ребенка
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

        //TODO: Не используется
        /// <summary>
        /// Отец
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Отец
        /// </summary>
        public Adult Father { get; set; }

        //TODO: Не используется
        /// <summary>
        /// Мать
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Мать
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Название детского сада или школы
        /// </summary>
        private string _nameOfKindergardenOrSchool;

        /// <summary>
        /// Название детского сада или школы
        /// </summary>
        public string NameOfKindergardenOrSchool
        {
            get { return _nameOfKindergardenOrSchool; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        $"{nameof(value)} is null or empty!");
                }

                _nameOfKindergardenOrSchool = value;
            }
        }

        #endregion

        #region Формирование информации

        /// <summary>
        /// Сформировать информацию о взрослом
        /// </summary>
        /// <returns>Информация о взрослом</returns>
        public override string InfoAboutPerson()
        {
            var infoAboutPerson = base.InfoAboutPerson() +
                $"\nНазвание детского сада или школы: " +
                $"{NameOfKindergardenOrSchool}\n";

            if (Mother != null)
            {
                infoAboutPerson += $"Мать:" +
                    $" {Mother.ShortInfoAboutPerson()} / ";
            }
            else
            {
                infoAboutPerson += "Матери нет / ";
            }

            if (Father != null)
            {
                infoAboutPerson += $"Отец:" +
                    $" {Father.ShortInfoAboutPerson()}";
            }
            else
            {
                infoAboutPerson += "Отца нет";
            }

            return infoAboutPerson;
        }

        #endregion
    }
}
