using System;
using PersonsLib;

namespace Andrejchenko.LabOne
{
    /// <summary>
    /// Тестирование
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Точка входа
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Чтобы начать работу программы " +
                "нажмите любую кнопку...");
            Console.ReadKey();

            Console.Write("\nСоздаем списки людей ---> ");
            var designDepartOne = new PersonList();
            var designDepartTwo = new PersonList();
            Console.WriteLine("Созданы успешно!");
            Console.Write("Заполняем списки ---> ");

            var peopleForListOne = new Person[]
            {
                new Person("Андрей", "Гришенков", 24, SexTypes.Male),
                new Person("Ванадий", "Ванадьев", 29, SexTypes.Male),
                new Person("Борис", "Борисенко", 21, SexTypes.Male)
            };

            var peopleForListTwo = new Person[]
{
                new Person("Юлия", "Шишко", 35, SexTypes.Female),
                new Person("Григорий", "Терешков", 31, SexTypes.Male),
                new Person("Лилия", "Сюдзенко", 24, SexTypes.Female)
            };

            designDepartOne.AddRangeOfPersons(peopleForListOne);
            designDepartTwo.AddRangeOfPersons(peopleForListTwo);

            Console.WriteLine("Заполнены успешно!");
            
            PrintPersonList(designDepartOne, designDepartTwo);

            Console.Write("Добавляем нового человека в первый список ---> ");
            var newDesignerDepartOne = new Person("Кирилл", "Ананьев",
                34, SexTypes.Male);
            designDepartOne.AddPerson(newDesignerDepartOne);
            
            Console.WriteLine("Добавлен успешно!");

            PrintPersonList(designDepartOne, designDepartTwo);

            Console.WriteLine("Копируем второго человека из " +
                "первого списка во второй ---> ");
            designDepartTwo.AddPerson(designDepartOne[1]);
            Console.WriteLine("Скопирован успешно!\n");

            PrintPersonList(designDepartOne, designDepartTwo);

            Console.WriteLine("Удаляем второго человека" +
                " из первого списка ---> ");
            designDepartOne.DelPersonByIndex(1);
            Console.WriteLine("Удален успешно!");

            PrintPersonList(designDepartOne, designDepartTwo);

            Console.Write("Очищаем второй список ---> ");
            designDepartTwo.Clear();

            Console.WriteLine("Очищен успешно!");

            PrintPersonList(designDepartOne, designDepartTwo);

            Console.Write("Добавляем во второй список " +
                "случайного человека ---> ");
            designDepartTwo.AddPerson(GetRandomPerson.ReceiveRandomPerson());
            Console.WriteLine("Добавлен успешно!");

            PrintPersonList(designDepartOne, designDepartTwo);

            Console.WriteLine("Добавим человека, получая параметры "
                +"от пользователя...");
            designDepartTwo.AddPerson(PersonInput.CreateNewPerson());

            PrintPersonList(designDepartOne, designDepartTwo);

            Console.Write("Чтобы завершить работу нажмите любую кнопку...");
            Console.ReadKey();

        }
        
        /// <summary>
        /// Вывод списка в консоль
        /// </summary>
        /// <param name="personListOne">Список 1</param>
        /// <param name="personListTwo">Список 2</param>
        public static void PrintPersonList(PersonList personListOne,
            PersonList personListTwo)
        {
            var personLists = new PersonList[]
            {
                personListOne,
                personListTwo
            };

            Console.WriteLine("Нажмите любую кнопку для вывода списков... ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("\n**********\n");

            for (int i = 0; i < personLists.Length; i++)
            {
                Console.WriteLine($"Список #{i + 1}\n");

                for (int j = 0; j < personLists[i].Size; j++)
                {
                    Console.WriteLine(
                        personLists[i][j].InfoAboutPerson());
                }

                Console.WriteLine();
            }

            Console.WriteLine("**********\n");
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
