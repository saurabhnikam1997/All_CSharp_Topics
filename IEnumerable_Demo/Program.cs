using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_Demo
{
    public class MyCollection : IEnumerable
    {
        private int[] data;

        public MyCollection(int[] elements)
        {
            data = elements;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(data);
        }
    }

    public class Emp : IList
    {
        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
    public class MyEnumerator : IEnumerator
    {
        private int[] data;
        private int currentIndex;

        public MyEnumerator(int[] elements)
        {
            data = elements;
            currentIndex = -1;
        }

        public object Current => data[currentIndex];

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < data.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int[] elements = { 1, 2, 3, 4, 5 };
            MyCollection collection = new MyCollection(elements);

            foreach (int element in collection)
            {
                Console.WriteLine(element);
            }

            Queue queue = new Queue();

            
        }
    }
}
