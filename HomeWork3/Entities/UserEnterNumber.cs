

namespace HomeWork4.Entities
{
    internal class UserEnterNumber : GameValue
    {
        public override  int SetValue()
        {
            int gessedNumber = 0;

            bool tryAgain = true;
            Console.WriteLine("Теперь попробуйте угадать число:");
            while (tryAgain)
            {
                if (int.TryParse(Console.ReadLine(), out gessedNumber))
                {
                    tryAgain = false;

                }
                else
                {
                    Console.Write("Вы ввели некорректное число. Поробуйте ввести еще раз:");

                }

            }
            return gessedNumber;
        }
    }
}
