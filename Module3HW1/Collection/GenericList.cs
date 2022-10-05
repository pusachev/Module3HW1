﻿using System;
using System.Collections;
using System.Reflection;

namespace Module3HW1.Collection
{
    public class GenericList<T> : IEnumerator<T>, IEnumerable<T>
    {
        private T[] _data;
        private int _index = 0;
        private int _currentIndex;
        private int _capacity = 0;

        public GenericList(int capacity = 8)
        {
            _capacity = capacity < 1 ? 1 : capacity;
            _data = new T[_capacity];
        }

        public int Length { get => _data.Length; }
        public bool IsEmpty { get => _data.Length == 0; }
        public T Current
        {
            get
            {
                if (_currentIndex == -1 || _currentIndex >= _data.Length)
                {
                    throw new InvalidOperationException();
                }

                return _data[_currentIndex];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Add(T input)
        {
#if DEBUG
            if (input != null)
            {
                Console.WriteLine(input.ToString());
            }
#endif
            try
            {
                _data[_index] = input;
            }
            catch (IndexOutOfRangeException)
            {
                Resize();
                _data[_index] = input;
            }

            _index++;
        }

        public void Delete(T input)
        {
            int searchIndex = -1;

            for (int i = 0; i < _index - 1; i++)
            {
                if (EqualityComparer<T>.Default.Equals(_data[i], input))
                {
                    Console.WriteLine($"Found index: {i}");
                    searchIndex = i;
                    break;
                }
            }

            if (searchIndex < 0)
            {
                return;
            }

            for (int i = searchIndex; i < _data.Length - 1; i++)
            {
                _data[i] = _data[i + 1];
            }

            Array.Resize(ref _data, _data.Length - 1);
        }

        public void Dispose()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_currentIndex < _data.Length - 1)
            {
                _currentIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Resize()
        {
            T[] resized = new T[_capacity * 2];
            for (int i = 0; i < _capacity; i++)
            {
                resized[i] = _data[i];
            }

            _capacity *= 2;
            _data = resized;
        }
    }
}
