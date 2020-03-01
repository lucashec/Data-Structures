using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class QueueLinkedList:IQueue
    {
        Node first, last;
        int size;
        public QueueLinkedList() {
            first = null;
            last = null;
            size = 0;
        }
        public void Enqueue(object current) {
            Node temp = new Node();
            temp.SetData(current);

            if(last == null) {
                first = temp;
                last = first;
            }
            else {
                last.SetNext(temp);

            }
            size++;
        }
        public object Dequeue() { 
            if (first == null) { throw new EmptyQueueException("The Queue is empty"); }
            Node temp = first;
            first = first.GetNext();
            size--;
            return temp.GetData();
           
        }
        public int Size() { return size; }
        public bool IsEmpty() { return first == null; }
        public object First() { return first; }
    }
}
 