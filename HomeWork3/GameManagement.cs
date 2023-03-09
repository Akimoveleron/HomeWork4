using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class GameManagement:IGameManagment
    {
        public Setting Setting { get; private set; }

        public int PickedNumber { get; private set; }

        public GameManagement(Setting setting)
        {
            Setting = setting;
            PickedNumber = new Random().Next(Setting.Range.Value.Item1, Setting.Range.Value.Item2 + 1);
        }



        public bool CheckWin(IEnterable<int> gessedNumber)
        {
            if (gessedNumber.Value==PickedNumber)
            {
                Console.WriteLine("Вы угадали!");
                return true;
            }else if (gessedNumber.Value <PickedNumber)
            {
                Console.WriteLine( "Загаданное число больше");
                return false;
            }else 
            {
                Console.WriteLine("Загаданное число меньше");
                return false;
            }

        }
    }
}
