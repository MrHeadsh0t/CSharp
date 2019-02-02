using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. * Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи.Все программы сделать в одном решении.
            //**Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
            //Добавить упрощение дробей.

            #region Input
            Console.WriteLine("Введите числитель первой дроби:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби:");
            int y = Convert.ToInt32(Console.ReadLine());

            Fraction fraction1 = new Fraction(x, y);

            Console.WriteLine("Введите числитель второй дроби:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби:");
            y = Convert.ToInt32(Console.ReadLine());

            Fraction fraction2 = new Fraction(x, y);
            Staff.cs();
            #endregion

            #region Output
            // Упрощение и печать
            fraction1.ToSimple().Print();
            fraction2.ToSimple().Print();
            Console.WriteLine();
            Staff.Pause();
            Staff.cs();
            
            //Сумма
            Console.WriteLine("Сумма дробей: ");
            Fraction.Summ(fraction1, fraction2).Print();
            Console.WriteLine();

            //Разность
            Console.WriteLine("Разность дробей: ");
            Fraction.Difference(fraction1, fraction2).Print();
            Console.WriteLine();

            //Произведение
            Console.WriteLine("Произведение дробей:");
            Fraction.Production(fraction1, fraction2).Print();
            Console.WriteLine();

            //Деление
            Console.WriteLine("Деление дробей: ");
            Fraction.Dividing(fraction1, fraction2).Print();
            #endregion

            Staff.Pause();

        }
    }
}
