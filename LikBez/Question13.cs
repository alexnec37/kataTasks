using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace LikBez
{
    class Person
    {
        private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();
        private int id = GetId();

        private static int GetId()
        {
            throw new NotImplementedException();
        }

        public Person(string name) => names.TryAdd(id, name); // конструктор
        ~Person() => names.TryRemove(id, out _);              // декструктор
        public string Name
        {
            get => names[id];                                 // геттер
            set => names[id] = value;                         // сеттер
        }
    }
}
