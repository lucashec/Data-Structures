using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class EmptyQueueException : Exception
    {
        public EmptyQueueException(string ex) : base(ex) { }
    }
}
