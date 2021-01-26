using System;
using System.Collections;
using System.Collections.Generic;
using Utils.Entity;

namespace HomeWork2.UserCollection
{
    /// <summary>
    /// 
    /// </summary>
    public class PhoneCollection<T> : IEnumerable<T> where T : IPhone
    {
        private readonly List<T> _list;

        public PhoneCollection(params T[] array)
        {
            _list = new List<T>(array);
        }

        public PhoneCollection(List<T> list)
        {
            _list = list;
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Remove(int index)
        {
            var item = _list[index];
            Remove(item);
        }

        public void Remove(T item)
        {
            if (_list.Count <= 5)
                throw new Exception("Нельзя удалить элемент, так количество элементов должно быть больше 5");
            _list.Remove(item);
        }

        public int Count => _list.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return new Iterator<T>(_list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Iterator<T> : IEnumerator<T> where T : IPhone
    {
        private readonly List<T> _list;
        private int _currentPosition = -1;

        public Iterator(List<T> list)
        {
            _list = list;
        }

        public bool MoveNext()
        {
            if (_currentPosition < _list.Count - 1)
            {
                _currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        public T Current => _list[_currentPosition];

        object IEnumerator.Current => Current!;

        public void Dispose()
        {
            _currentPosition = -1;
        }
    }
}
