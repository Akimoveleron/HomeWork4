using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal interface IEnterableTuple
    {
        public (int,int) Value { get; set; }

        public (int,int) Enter();
    }
}
