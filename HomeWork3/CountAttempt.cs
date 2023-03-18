using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class CountAttempt : IEnterable
    {
        public int Value { get; set; }

        public CountAttempt()
        {
            Value = Enter();
        }
        public int Enter()
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
