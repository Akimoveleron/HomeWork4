using HomeWork4.Interfaces;


namespace HomeWork4
{
    internal class GameManagement:IGameManager
    {

        public int Init(ISetting setting)
        {
            return setting.SetValue();
        }



        public bool CheckWin(int userValue, int pickedNumber )
        {
            if (userValue == pickedNumber)
            {
                Console.WriteLine("Вы угадали!");
                return true;
            }else if (userValue < pickedNumber)
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
