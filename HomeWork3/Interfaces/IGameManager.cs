using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Interfaces
{
    internal interface IGameManager
    {
        public bool CheckWin(int userValue, int pickedNumber);
    }
}
