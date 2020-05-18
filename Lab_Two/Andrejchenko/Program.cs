using System;
using PersonsLib;

namespace Andrejchenko.LabTwo
{
    /// <summary>
    /// Тестирование
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Точка входа
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("Чтобы начать работу программы " +
                "нажмите любую кнопку...");
            Console.ReadKey();

            Console.Write("\nГенерируем список из 7 людей ---> ");
            var listPersons = new PersonList();
            Console.WriteLine("Создан успешно!");

            Console.Write("Заполняем списки ---> ");

            for (int i = 0; i < 7; i++)
            {
                listPersons.AddPerson(GetRandomPerson.CreateRandomPerson());
            }

            Console.WriteLine("Заполнены успешно!");
            Console.WriteLine("Случайно сгенерированный список:");
            Console.WriteLine("\n**********\n");

            for (int i = 0; i < listPersons.Size; i++)
            {
                Console.WriteLine(listPersons[i].InfoAboutPerson());
                Console.WriteLine();
            }

            Console.WriteLine("\n**********\n");

            Console.Write("Определим четвертого человека в списке. Это - ");

            switch (listPersons[3])
            {
                case Adult adult:
                {
                    Console.Write("взрослый человек.");
                    var person = listPersons[3] as Adult;
                    Console.WriteLine(person.WatchTV());
                    break;
                }
                case Child child:
                {
                    Console.Write("ребенок.");
                    var person = listPersons[3] as Child;
                    Console.WriteLine(person.TryWatchTV());
                    break;
                }
            }

            Console.WriteLine(listPersons[3].WhoAmI());

            Console.ReadKey();
        }
    }
}
