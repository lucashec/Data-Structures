using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class EmptyStackException:Exception
    {
        public EmptyStackException(string ex) : base(ex) { }
    }
}
