using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class DoubleNode
    {
        private object data;
        private DoubleNode next;
        private DoubleNode previous;
        public object GetData() { return data; }
        public void SetData(object data) { this.data = data; }

        public DoubleNode GetNext() { return next; }
        public void SetNext(DoubleNode next) { this.next = next; }
        public DoubleNode GetPrevious() { return previous; }
        public void SetPrevious(DoubleNode prev) { previous = prev; }
    }
}
