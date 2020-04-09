using System;
using PersonsLib;

namespace Andrejchenko.LabTwo
{
    /// <summary>
    /// Класс для наименования случайного человека
    /// </summary>
    public static class GetRandomPerson
    {

        #region Поля

        /// <summary>
        /// Новый рандом
        /// </summary>
        private static Random _random = new Random();

        #endregion

        #region Методы

        /// <summary>
        /// Генерация случайного человека: взрослый или ребенок
        /// </summary>
        /// <returns>Сгенерированный ребенок или взрослый</returns>
        public static Person CreateRandomPerson()
        {
            if (_random.Next(0, 2) != 0)
            {
                return ReceiveRandomChild();
            }
            else
            {
                return ReceiveRandomAdult();
            }
        }

        //TODO: Учесть пол при формировании родителей и супругов
        /// <summary>
        /// Задание случайного взрослого
        /// </summary>
        /// <param name="forMarriage">Генерация партнера
        /// для человека, состоящего в браке</param>
        /// <param name="partner">Партнер</param>
        /// <returns>Сгенерированный взрослый</returns>
        public static Adult ReceiveRandomAdult(bool forMarriage = false,
            Adult partner = null)
        {
            var randomAdult = new Adult();

            ReceiveRandomPersonBaseProp(randomAdult);

            randomAdult.Age = _random.Next(Adult.MINAGE, Adult.MAXAGE);

            if (!forMarriage)
            {
                randomAdult.MarriageStatus =
                    (MarriageStatus)_random.Next(0, 4);

                if (randomAdult.MarriageStatus == MarriageStatus.Married)
                {
                    randomAdult.Partner = 
                        ReceiveRandomAdult(true, randomAdult);
                }
            }
            else
            {
                randomAdult.MarriageStatus = MarriageStatus.Married;
                randomAdult.Partner = partner;
            }

            var allCompanyNames =
                Properties.Resources.CompanyNames.Split('\n');
            var companyRandomIndex =
                _random.Next(0, allCompanyNames.Length - 1);
            randomAdult.PlaceOfWork =
                allCompanyNames[companyRandomIndex];

            randomAdult.PassportNumber = GetRandomPassportData(true);
            randomAdult.PassportSerial = GetRandomPassportData(false);

            return randomAdult;
        }

        /// <summary>
        /// Задание случайного ребенка
        /// </summary>
        /// <returns>Сгенерированный ребенок</returns>
        public static Child ReceiveRandomChild()
        {
            var randomChild = new Child();

            ReceiveRandomPersonBaseProp(randomChild);

            randomChild.Age = _random.Next(Child.MINAGE, Child.MAXAGE);

            var haveMother = _random.Next(0, 1);

            if (haveMother == 0)
            {
                randomChild.Mother = ReceiveRandomAdult();
            }

            var haveFather = _random.Next(0, 1);

            if (haveFather == 0)
            {
                randomChild.Father = ReceiveRandomAdult();
            }

            var allPlaceOfTeachChildNames =
                Properties.Resources.PlaceOfTeachChild.Split('\n');
            var placeOfTeachChildNamesRandomIndex =
                _random.Next(0, allPlaceOfTeachChildNames.Length - 1);
            randomChild.NameOfKindergardenOrSchool =
                allPlaceOfTeachChildNames[placeOfTeachChildNamesRandomIndex];

            return randomChild;
        }

        //TODO Сигнатура XML комментария и метода различны
        /// <summary>
        /// Сгенерировать номер или серию паспорта
        /// </summary>
        /// <param name="isPassportNumber">Генерировать номер</param>
        /// <returns>Номер или серия</returns>
        private static string GetRandomPassportData(bool isNumber)
        {
            string data;

            if (isNumber)
            {
                data = FillPassportDataWithZeros(
                    _random.Next(0, 999999).ToString(), 6);
            }
            else
            {
                data = FillPassportDataWithZeros(
                    _random.Next(0, 9999).ToString(), 4);
            }

            return data;
        }

        /// <summary>
        /// Заполнить нули в начале номера или серии паспорта
        /// </summary>
        /// <param name="PassportData">Серия или номер паспорта</param>
        /// <param name="lenghtRequriedPassportData">Исправленное 
        /// значение</param>
        /// <returns>Номер или серия</returns>
        private static string FillPassportDataWithZeros(
            //TODO: RSDN
            string PassportData, int lenghtRequriedPassportData)
        {
            if (PassportData.Length < lenghtRequriedPassportData)
            {
                var amountOfZero =
                    lenghtRequriedPassportData - PassportData.Length;

                for (int i = 0; i < amountOfZero; i++)
                {
                    PassportData = "0" + PassportData;
                }
            }

            return PassportData;
        }

        /// <summary>
        /// Задание базовых полей человека
        /// </summary>
        /// <param name="person">Персона для заполнения</param>
        public static void ReceiveRandomPersonBaseProp(Person person)
        {
            var randomSexType = _random.Next(0, 1);

            //TODO: 1ЛР
            if (randomSexType == 0)
            {
                person.SexType = SexTypes.Male;

                GetRandomPersonBaseProp(Properties.Resources.LastName_Male,
                    Properties.Resources.FirstName_Male, person);

            }
            else if (randomSexType == 1)
            {
                person.SexType = SexTypes.Female;

                GetRandomPersonBaseProp(Properties.Resources.FirstName_Female,
                    Properties.Resources.LastName_Female, person);
            }
        }

        /// <summary>
        /// Вспомогательный метод задания базовых полей человека
        /// </summary>
        /// <param name="lastNames">Фамилия</param>
        /// <param name="firstNames">Имя</param>
        /// <param name="person">Персона</param>
        public static void GetRandomPersonBaseProp(string lastNames,
            string firstNames, Person person)
        {
            //TODO: 1ЛР
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

        #endregion
    }
}
