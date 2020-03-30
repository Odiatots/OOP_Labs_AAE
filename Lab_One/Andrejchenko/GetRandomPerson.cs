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

            if (randomSexType == 0)
            {
                randomPerson.SexType = SexTypes.Male;

                //TODO: Дубль (исправлено)
                GetRandomPersonProp(Properties.Resources.LastName_Male,
                    Properties.Resources.FirstName_Male, randomPerson);

            }
            else if (randomSexType == 1)
            {
                randomPerson.SexType = SexTypes.Female;

                //TODO: Дубль (исправлено)
                GetRandomPersonProp(Properties.Resources.FirstName_Female,
                    Properties.Resources.LastName_Female, randomPerson);
            }
            return randomPerson;
        }

        /// <summary>
        /// Вспомогательный метод генерации персоны
        /// </summary>
        /// <param name="lastNames">Фамилия</param>
        /// <param name="firstNames">Имя</param>
        /// <param name="person">Персона</param>
        public static void GetRandomPersonProp(string lastNames,
            string firstNames, Person person)
        {
            var baseFirstNames =
                firstNames.Split('\n');
            var baseLastNames =
                lastNames.Split('\n');

            var firstNameRandomIndex =
                _random.Next(0, baseFirstNames.Length - 1);
            var lastNameRandomIndex =
                _random.Next(0, baseLastNames.Length - 1);

            person.FirstName =
                baseFirstNames[firstNameRandomIndex].Substring(0,
                baseFirstNames[firstNameRandomIndex].Length - 1);
            person.LastName =
                baseLastNames[lastNameRandomIndex].Substring(0,
                baseLastNames[lastNameRandomIndex].Length - 1);
        }
    }
}
