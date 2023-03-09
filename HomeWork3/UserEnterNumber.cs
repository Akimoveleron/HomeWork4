using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class UserEnterNumber :IEnterable<int>
    {
        public int Value { get; set; }
        public UserEnterNumber()
        {
            Value = Enter();
        }

        public  int Enter()
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
