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
        public static PersonBase CreateRandomPerson()
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

        //TODO: Учесть пол при формировании родителей и супругов - исправлено
        /// <summary>
        /// Задание случайного взрослого
        /// </summary>
        /// <param name="forMarriage">Генерация партнера
        /// для человека, состоящего в браке</param>
        /// <param name="partner">Партнер</param>
        /// <param name="sexType">Пол человека, для
        /// формирования супругов</param>
        /// <returns>Сгенерированный взрослый</returns>
        public static Adult ReceiveRandomAdult(bool forMarriage = false,
            Adult partner = null, string sexType = null)
        {
            var randomAdult = new Adult();

            ReceiveRandomPersonBaseProp(randomAdult, sexType);

            randomAdult.Age = _random.Next(Adult.MINAGE, Adult.MAXAGE);

            if (!forMarriage)
            {
                randomAdult.MarriageStatus =
                    (MarriageStatus)_random.Next(0, 4);

                if (randomAdult.MarriageStatus == MarriageStatus.Married)
                {
                    switch (randomAdult.SexType)
                    {
                        case SexTypes.Male:
                            randomAdult.Partner = ReceiveRandomAdult(
                                true, randomAdult, "Female");
                            break;

                        case SexTypes.Female:
                            randomAdult.Partner = ReceiveRandomAdult(
                                true, randomAdult, "Male");
                            break;
                    }
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

            // По статистике 2,5% детей растут без матери,
            // поэтому такой интервал
            var haveMother = _random.Next(0, 40);

            if (!(haveMother == 0))
                randomChild.Mother = ReceiveRandomAdult(sexType: "Female");

            // По статистике 25% детей растут без отца,
            // поэтому такой интервал
            var haveFather = _random.Next(0, 5);

            if (!(haveFather == 0))
                randomChild.Father = ReceiveRandomAdult(sexType: "Male");

            var allPlaceOfTeachChildNames =
                Properties.Resources.PlaceOfTeachChild.Split('\n');
            var placeOfTeachChildNamesRandomIndex =
                _random.Next(0, allPlaceOfTeachChildNames.Length - 1);
            randomChild.NameOfKindergardenOrSchool =
                allPlaceOfTeachChildNames[placeOfTeachChildNamesRandomIndex];

            return randomChild;
        }

        //TODO Сигнатура XML комментария и метода различны - исправлено
        /// <summary>
        /// Сгенерировать номер или серию паспорта
        /// </summary>
        /// <param name="isNumber">Генерировать номер</param>
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
        /// <param name="passportData">Серия или номер паспорта</param>
        /// <param name="lenghtRequriedPassportData">Исправленное 
        /// значение</param>
        /// <returns>Номер или серия</returns>
        private static string FillPassportDataWithZeros(
            //TODO: RSDN - исправлено
            string passportData, int lenghtRequriedPassportData)
        {
            if (passportData.Length < lenghtRequriedPassportData)
            {
                var amountOfZero =
                    lenghtRequriedPassportData - passportData.Length;

                for (int i = 0; i < amountOfZero; i++)
                {
                    passportData = "0" + passportData;
                }
            }

            return passportData;
        }

        /// <summary>
        /// Задание базовых полей человека
        /// </summary>
        /// <param name="person">Персона для заполнения</param>
        /// <param name="sexType">Пол человека, для 
        /// формирования супругов</param>
        public static void ReceiveRandomPersonBaseProp(PersonBase person, 
            string sexType = null)
        {
            var randomSexType = _random.Next(0, 2);

            if (!(sexType == null))
            {
                switch (sexType)
                {
                    case "Male":
                        randomSexType = 0;
                        break;
                    case "Female":
                        randomSexType = 1;
                        break;
                }
            }         

            //TODO: 1ЛР - исправлено
            switch (randomSexType)
            {
                case 0:
                    person.SexType = SexTypes.Male;
                    person.FirstName = GetRandomPersonBaseNames(
                        Properties.Resources.FirstName_Male);
                    person.LastName = GetRandomPersonBaseNames(
                        Properties.Resources.LastName_Male);
                    break;
                case 1:
                    person.SexType = SexTypes.Female;
                    person.FirstName = GetRandomPersonBaseNames(
                        Properties.Resources.FirstName_Female);
                    person.LastName = GetRandomPersonBaseNames(
                        Properties.Resources.LastName_Female);
                    break;
            }
        }

        /// <summary>
        /// Вспомогательный метод генерации имен персоны
        /// </summary>
        /// <param name="names">Список имен или фамилий</param>
        /// <returns>Фамилия или имя</returns>
        public static string GetRandomPersonBaseNames(string names)
        {
            //TODO: 1ЛР - исправлено
            var baseNames = names.Split('\n');

            var nameRandomIndex = _random.Next(0, baseNames.Length - 1);

            return baseNames[nameRandomIndex].Substring(0,
                baseNames[nameRandomIndex].Length - 1);
        }

        #endregion
    }
}
