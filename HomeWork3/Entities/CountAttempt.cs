

using HomeWork4.Abstract;

namespace HomeWork4.Entities
{
    internal class CountAttempt : SettingItem
    {
      public override int SetValue()
        {
            Console.WriteLine("Введите количество попыток от 1 до 10");
            bool tryAgain = true;
            int numberOfAttempts = 1;
            while (tryAgain)
            {
                if (int.TryParse(Console.ReadLine(), out numberOfAttempts))
                {

                    if (numberOfAttempts < 1 || numberOfAttempts > 10)
                    {
                        Console.WriteLine();
                        Console.Write("Количество попыток должно входит в диапозон от 1 до 10.Поробуйте ввести еще раз:");

                    }
                    else tryAgain = false;

                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Вы ввели некорректное число. Поробуйте ввести еще раз:");
                }

            }
            return numberOfAttempts;
        }
    }
}
