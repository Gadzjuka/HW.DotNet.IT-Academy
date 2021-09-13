using System;
using System.Collections.Generic;
using System.Text;

namespace Queue.Models
{
    class CastomQueueObject
    {
        private int _front = -1;
        private int _rear = -1;
        private int _count = 0;
        private int _size;
        private object[] _array;

        public CastomQueueObject(int size)
        {
            _size = size;
            _array = new object[size];
        }
        public int Size
        {
            get { return _size; }
        }
        public void Enqueue(object item)
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
            object value = _array[++_front];
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
