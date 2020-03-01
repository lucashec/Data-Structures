using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    interface IQueue
    {
        public int Size();
        public bool IsEmpty();
        public object First();
        public void Enqueue(object current);
        public object Dequeue();
    }
}
