using System;
using System.Collections.Generic;
using System.Text;

namespace Queue.Models
{
    class CastomQueue<T> where T: class
    {
        private int _front = -1;
        private int _rear = -1;
        private int _count = 0;
        private int _size;
        private T[] _array;
        public CastomQueue()
        {
            _size = 0;
            _array = new T[0];
        }

        public CastomQueue(int size)
        {
            _size = size;
            _array = new T[size];
        }
        public int Size
        {
            get { return _size; }
        }
        public void Enqueue(T item)
        {
            if (this.IsFull())
            {
                Array.Resize(ref _array, _array.Length + 1);
                _size++;
            }
            _array[++_rear] = item;
            _count++;
        }
        public object Dequeue()
        {
            if (this.IsEmpty())
                throw new Exception("Queue is empty!!!");
            T value = _array[++_front];
            _count--;
            if (_front == _rear)
            {
                _front = -1;
                _rear = -1;
            }
            return value;
        }
        public object Peek()
        {
            if (this.IsEmpty())
                throw new Exception("Queue is empty!!!");
            return _array[_front + 1];
        }
        public bool IsFull()
        {
            return _rear == _size - 1;
        }
        public bool IsEmpty()
        {
            return _count == 0;
        }
    }
}
