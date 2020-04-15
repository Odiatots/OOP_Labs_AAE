using System;
using PersonsLib;

namespace Andrejchenko.LabOne
{
    /// <summary>
    /// Класс для наименования случайного человека
    /// </summary>
    public static class GetRandomPerson
    {
        /// <summary>
        /// Новый рандом
        /// </summary>
        private static Random _random = new Random();
                     
        /// <summary>
        /// Задание случайного человека
        /// </summary>
        /// <returns>Случайный человек</returns>
        public static Person ReceiveRandomPerson()
        {
            var randomPerson = new Person();

            var randomSexType = _random.Next(0, 1);
            randomPerson.Age = _random.Next(0, 100);

            //TODO: Правильнее в switch-case, а не if-else - исправлено

            switch (randomSexType)
            {
                case 0:
                    randomPerson.SexType = SexTypes.Male;
                    randomPerson.FirstName = GetRandomPersonNames(
                        Properties.Resources.FirstName_Male);
                    randomPerson.LastName = GetRandomPersonNames(
                        Properties.Resources.LastName_Male);
                    break;
                case 1:
                    randomPerson.SexType = SexTypes.Female;
                    randomPerson.FirstName = GetRandomPersonNames(
                        Properties.Resources.FirstName_Female);
                    randomPerson.LastName = GetRandomPersonNames(
                        Properties.Resources.LastName_Female);
                    break;
            }
            return randomPerson;
        }

        /// <summary>
        /// Вспомогательный метод генерации имен персоны
        /// </summary>
        /// <param name="names">Список имен или фамилий</param>
        /// <returns></returns>
        public static string GetRandomPersonNames(string names)
        {
            //TODO: Алгоритм генерации имени и фамилии дублируется, правильно их вынести в отдельный метод,
            //TODO: а из него уже возвращать строку имя/фамилия и присваивать уже нужному свойству персоны - исправлено
            var baseNames = names.Split('\n');

            var nameRandomIndex = _random.Next(0, baseNames.Length - 1);

            return baseNames[nameRandomIndex].Substring(0,
                baseNames[nameRandomIndex].Length - 1);

        }

    }
}
