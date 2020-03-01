using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Queue:IQueue
    {
        public int first, last, length, size;
        public object[] data;
        public Queue(int length)
        {
            data = new object[length];
            this.length = length;
            first = 0;
            last = 0;
            size = 0;
        }
        public void Enqueue(object current)
        {
            int newLength = 2 * length;
            object[] temp = new object[newLength];

            if (size < length)
            {
                data[last] = current;
                last = (last + 1) % length;
                size++;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    temp[i] = data[i];
                }
                temp[last + 1] = current;
                data = temp;
                length = newLength;
                last = (last + 1) % length;
                size++;
            }
            
        }
        public object Dequeue()
        {
            if (IsEmpty()) { throw new EmptyQueueException("The Queue is empty"); }

            object element = data[first];
            data[first] = null;
            first = (first + 1) % length;
            size--;

            return element;


        }
        public int Size() { return size; }

        public bool IsEmpty() { return size == 0; }
        public object First() { return data[first]; }
    }
}
