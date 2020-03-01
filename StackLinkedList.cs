using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class StackLinkedList
    {
        private Node top;

        public StackLinkedList()
        {
            top = null;
        }
        public object Top()
        {
            if (IsEmpty()) { throw new EmptyStackException("The Stack is empty"); }
            else { return top; }
        }
        public bool IsEmpty()
        {
            return top == null;
        }
        public void Push(object current)
        {
            Node temp = new Node();
            temp.SetData(current);
            temp.SetNext(top);
            top = temp;

        }
        public object Pop()
        {
            object currentTop;
            if (IsEmpty()) { throw new EmptyStackException("The Stack is empty"); }
            else
            {
                currentTop = top.GetData();
                top = top.GetNext();
            }
            return currentTop;
        }
        
    }
}
