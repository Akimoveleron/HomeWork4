

using HomeWork4.Abstract;

namespace HomeWork4.Entities
{
    internal class PickedNumber : SettingItem
    {  
        public override int SetValue()
        {
            Console.Write("Введите диапазон значений. Введите первое число:");

            int leftBorder = 0;
            int rightBorder = 0;
            int pickedNumber = 0;
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

            pickedNumber = new Random().Next(leftBorder, rightBorder + 1);
            return pickedNumber;
        }
    }
}
