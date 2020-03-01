using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class EmptyDequeException:Exception
    {
        public EmptyDequeException(string ex) : base(ex) { }
    }
}
