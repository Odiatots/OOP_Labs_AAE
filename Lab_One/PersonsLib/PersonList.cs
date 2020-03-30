using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsLib
{
    /// <summary>
    /// Список людей
    /// </summary>
    public class PersonList
    {
        #region Поле
        /// <summary>
        /// Массив со списком людей
        /// </summary>
        private Person[] _personList;
        #endregion

        #region Свойства
        /// <summary>
        /// Возвращает число элементов списка людей
        /// </summary>
        public int Size
        {
            get { return _personList.Length; }
        } 
        #endregion

        #region Индексатор
        /// <summary>
        /// Индексатор, возвращает человека из списка по индексу
        /// </summary>
        /// <param name="index">Индекс в списке людей</param>
        /// <returns>Экземпляр класса PersonList</returns>
        public Person this[int index]
        {
            get
            {
                if (index < 0 || index > Size - 1)
                {
                    throw new IndexOutOfRangeException(
                        $"Index must be non-negative and less " +
                        $"than the size of the list.");
                }
                return _personList[index];
            }
        }
        #endregion

        #region Конструктор
        /// <summary>
        /// Конструктор списка людей, инициализирует пустой массив
        /// </summary>
        public PersonList()
        {
            Clear();
        }
        #endregion

        #region Методы
        /// <summary>
        /// Полностью очищает список
        /// </summary>
        public void Clear()
        {
            _personList = new Person[0];
        }

        /// <summary>
        /// Добавление элемента в список людей
        /// </summary>
        /// <param name="person">Новый человек</param>
        public void AddPerson(Person person)
        {
            var bufferOfPerson = _personList;

            _personList = new Person[bufferOfPerson.Length + 1];

            for (int i = 0; i < bufferOfPerson.Length; i++)
            {
                _personList[i] = bufferOfPerson[i];
            }

            _personList[bufferOfPerson.Length] = person;
        }

        /// <summary>
        /// Возвращает индекс элемента в списке
        /// по переднному экземпляру объекта класса Person
        /// </summary>
        /// <param name="person">Экземпляр класса Person</param>
        /// <returns>Индекс человека в списке</returns>
        public int GetIndexOfPerson(Person person)
        {
            for (int i = 0; i < _personList.Length; i++)
            {
                if (person == _personList[i])
                {
                    return i;
                }
            }

            throw new KeyNotFoundException("There is no such person in " +
                "this list.");
        }

        /// <summary>
        /// Удалает элемент из списка при совпадении с переданным
        /// экземпляром класса Person
        /// </summary>
        /// <param name="person">Экземпляр класса Person</param>
        public void DelPerson(Person person)
        {
            DelPersonByIndex(GetIndexOfPerson(person));
        }

        /// <summary>
        /// Удаляет элемент из списка по индексу
        /// </summary>
        /// <param name="index">Индекс элемента</param>
        public void DelPersonByIndex(int index)
        {
            if (index < 0 || index > _personList.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            var bufferOfPerson = _personList;
            int counter = 0;
            _personList = new Person[bufferOfPerson.Length - 1];

            for (int i = 0; i < bufferOfPerson.Length; i++)
            {
                if (i != index)
                {
                    _personList[counter] = bufferOfPerson[i];
                    counter++;
                }
            }
        }

        /// <summary>
        /// Добавление нескольких людей в конец списка
        /// </summary>
        /// <param name="persons">Массив людей</param>
        public void AddRangeOfPersons(Person[] persons)
        {
            foreach (Person person in persons)
            {
                AddPerson(person);
            }
        } 
        #endregion
    }
}
