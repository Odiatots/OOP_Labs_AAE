using System;
using System.Collections.Generic;
using System.Linq;
using PersonsLib;

namespace Andrejchenko.LabOne
{
    /// <summary>
    /// Ввод/вывод данных через консоль
    /// </summary>
    public static class PersonInput
    {
        /// <summary>
        /// Создание новго экземпляра класса Person
        /// с указанием необходимых полей с клавиатуры
        /// </summary>
        /// <returns>Новый экземпляр класса Person</returns>
        public static Person CreateNewPerson()
        {
            var newPerson = new Person();
            var actionList = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Фамилия: ");
                    newPerson.FirstName = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Имя: ");
                    newPerson.LastName = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Возраст (0-100): ");
                    newPerson.Age = int.Parse(Console.ReadLine());
                }),
                new Action(() =>
                {
                    Console.Write("Пол (М/Ж): ");
                    var bufferConsole = Console.ReadLine();
                    var consoleFirstLetter = bufferConsole.First().ToString().ToUpper();

                    switch (consoleFirstLetter)
                    {
                        case "М":
                            bufferConsole = nameof(SexTypes.Male);
                            break;
                        case "Ж":
                            bufferConsole = nameof(SexTypes.Female);
                            break;
                    }
                    newPerson.SexType = (SexTypes)Enum.Parse(
                        typeof(SexTypes), bufferConsole);
                })
            };
            actionList.ForEach(SetValue);
            return newPerson;
        }

        /// <summary>
        /// Получить пользовательский ввод и задать параметр
        /// </summary>
        /// <param name="action">Делегат с заданием параметра</param>
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine($"{argumentException.Message}\n");
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"{formatException.Message}\n");
                }
            }
        }
    }
}
