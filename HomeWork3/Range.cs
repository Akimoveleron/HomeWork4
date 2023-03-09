using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class RangeOfValues : IEnterable <(int,int)>
    {
        public (int, int) Value { get;set; }

        public RangeOfValues()
        {
           Value = Enter();
        }


       public  (int, int) Enter()
        {
            Console.Write("Введите диапазон значений. Введите первое число:");

            int leftBorder = 0;
            int rightBorder = 0;
            bool leftBorderCorrect = false;
            bool rightBorderCorrect = false;
            while (!leftBorderCorrect || !rightBorderCorrect)
            {
                if (!leftBorderCorrect && int.TryParse(Console.ReadLine(), out leftBorder))
                {
                    leftBorderCorrect = true;
                    Console.Write("Введите второе число:");
                }
                else if (!rightBorderCorrect && int.TryParse(Console.ReadLine(), out rightBorder))
                {
                    if (rightBorder <= leftBorder)
                    {
                        Console.WriteLine();
                        Console.Write("Второе число должно быть больше второго числа.Поробуйте ввести еще раз:");
                    }
                    else
                    {
                        rightBorderCorrect = true;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Вы ввели некорректное число. Поробуйте ввести еще раз:");
               }
            }
           return (leftBorder,rightBorder);
        }
    }
}
