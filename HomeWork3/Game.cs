
using HomeWork4.Entities;

namespace HomeWork4
{
    internal class Game
    {
      
        public GameManagement GameManagement { get; set; }
     
        public Game(GameManagement gameManagement)
        {
            GameManagement = gameManagement;
        }

       
        public void Run()
        {
            Console.WriteLine("Привет! Давай поиграем. ");
            int countAttemp = GameManagement.Init(new CountAttempt());
            int pickedValue = GameManagement.Init(new PickedNumber());          
            bool isWin = false;

            for (int i = 0; i < countAttemp; i++)
            {
                int userValue = GameManagement. Init(new UserEnterNumber());          
              isWin =  GameManagement.CheckWin(pickedValue, userValue);
                if (isWin) return;       
            }
            Console.WriteLine( "Вы проиграли!");
        }
    }
}
