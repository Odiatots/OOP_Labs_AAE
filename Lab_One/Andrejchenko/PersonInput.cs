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
                    var buffer = Console.ReadLine();
                    buffer = buffer.First().ToString().ToUpper();
                    switch (buffer)
                    {
                        case "М":
                            buffer = "Male";
                            break;
                        case "Ж":
                            buffer = "Female";
                            break;
                    }
                    newPerson.SexType = (SexTypes)Enum.Parse(
                        typeof(SexTypes), buffer);
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
