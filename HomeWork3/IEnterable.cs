using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal interface IEnterable <T>
    {
        public T Value { get;  set; }

       public T Enter();
    }
}
