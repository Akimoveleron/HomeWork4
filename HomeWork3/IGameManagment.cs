using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal interface IGameManagment
    {
        public bool CheckWin(IEnterable<int> value);
    }
}
