using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Node
    {
        private object data;
        private Node next;

        public object GetData() { return data; }
        public void SetData(object data) { this.data = data; }

        override public string ToString() { return $"{GetData()}"; }
        public Node GetNext() { return next; }
        public void SetNext(Node next) { this.next = next; }

    }
}
