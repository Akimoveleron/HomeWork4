using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Game
    {
        public Setting Setting { get; set; }
        public GameManagement GameManagement { get; set; }
     

       


        public void Run()
        {
            Console.WriteLine("Привет! Давай поиграем. ");
            Setting = new Setting(new RangeOfValues(), new CountAttempt());
            GameManagement = new GameManagement(Setting);          
            bool isWin = false;

            for (int i = 0; i < Setting.NumberOfAttempt.Value ; i++)
            {            
              isWin =  GameManagement.CheckWin(new UserEnterNumber());
                if (isWin) return;       
            }
            Console.WriteLine( "Вы проиграли!");
        }
    }
}
