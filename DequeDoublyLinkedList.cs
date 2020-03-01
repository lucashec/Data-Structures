using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class DequeDoublyLinkedList
    {
        private DoubleNode front;
        private DoubleNode back;
        private int size;
        public DequeDoublyLinkedList() {
            front = back = null;
            size = 0;
        }
        public bool IsEmpty() {
            return (front == null);
        }
        public int Size() {
            return size;
        }
        public void InsertFront(object data) {
            DoubleNode temp = new DoubleNode();
            temp.SetData(data);

            if(front == null) {
                back = front = temp;
            }
            else {
                temp.SetNext(front);
                front.SetPrevious(temp);
                front = temp;
            }
            size++;

        }
        public void InsertBack(object data) {
            DoubleNode temp = new DoubleNode();
            temp.SetData(data);

            if (back == null)
            {
                front = back = temp;
            }
            else
            {
                temp.SetPrevious(back);
                back.SetNext(temp);
                back = temp;
            }
            size++;
        }
        public DoubleNode DeleteFront() {
            DoubleNode temp;
            if (IsEmpty()) { throw new EmptyDequeException("The Deque is empty"); }

            else {
                temp = front;
                front = front.GetNext();
            }
            return temp;
        }
        public DoubleNode DeleteBack()
        {
            DoubleNode temp;
            if (IsEmpty()) { throw new EmptyDequeException("The Deque is empty"); }

            else
            {
                temp = back;
                back = back.GetPrevious();
            }
            return temp;
        }
        public object GetFront() {
            if (IsEmpty()) {throw new EmptyDequeException("The Deque is empty"); }
            return front.GetData();
        }
        public object GetBack()
        {
            if (IsEmpty()) { throw new EmptyDequeException("The Deque is empty"); }
            return back.GetData();
        }

    }
}
