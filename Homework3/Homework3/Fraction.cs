using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Fraction
    {
        /// <summary>
        /// Числитель дроби
        /// </summary>
        public int a;
        /// <summary>
        /// Знаменатель дроби
        /// </summary>
        public int b;
        /// <summary>
        /// Результат произведения дроби
        /// </summary>
        double res;

        /// <summary>
        /// Создать дробь
        /// </summary>
        /// <param name="a">Числитель дроби</param>
        /// <param name="b">Знаменатель дроби</param>
        public Fraction(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }

            this.a = a;
            this.b = b;
            res = this.a / this.b;
        }


        /// <summary>
        /// Выводит дробь на экран
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Ваша дробь: {a} / {b}, ее результат: {res:0.####}.");
        }

        /// <summary>
        /// Сумма двух дробей
        /// </summary>
        /// <param name="fr1">Первая дробь</param>
        /// <param name="fr2">Вторая дробь</param>
        /// <returns>new Fraction</returns>
        static public Fraction Summ(Fraction fr1, Fraction fr2)
        {
            if (fr1.b == fr2.b)
            {
                return new Fraction(fr1.a + fr2.a, fr1.b).ToSimple();
            }
            else
            {
                //Приводим к общему знаменателю
                int save = fr1.b;
                fr1.a *= fr2.b;
                fr1.b *= fr2.b;

                fr2.a *= save;
                fr2.b *= save;

                return new Fraction(fr1.a + fr2.a, fr1.b).ToSimple();
            }
        }


        /// <summary>
        /// Вычесть из дроби a дробь b
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        static public Fraction Difference(Fraction a, Fraction b)
        {
            if (a.b == b.b)
            {
                return new Fraction(a.a - b.a, a.b).ToSimple();
            }
            else
            {
                //Приводим к общему знаменателю
                int save = a.b;
                a.a *= b.b;
                a.b *= b.b;

                b.a *= save;
                b.b *= save;

                return new Fraction(a.a - b.a, a.b).ToSimple();
            }
        }

        /// <summary>
        /// Произведение двух дробей
        /// </summary>
        /// <param name="fr1">Первая дробь</param>
        /// <param name="fr2">Вторая дробь</param>
        /// <returns>new Fraction</returns>
        static public Fraction Production(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.a * fr2.a, fr1.b * fr2.b).ToSimple();
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns>new Fraction</returns>
        static public Fraction Dividing(Fraction a, Fraction b)
        {
            // (a/b) / (c/d) = (a / b) * (d/c) = (ad) / (bc)

            return new Fraction(a.a * b.b, a.b * b.a).ToSimple();
        }

        /// <summary>
        /// Упрощение дроби
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <returns>new Fraction</returns>
        public Fraction ToSimple()
        {
            int max;
            if (a < b)
            {
                 max = a;
            }
            else
            {
                max = b;
            }

            for(int i = 2; i <= max; i++)
            {
                if (((a % i) == 0) && ((b % i) == 0))
                {
                    return (new Fraction(a / i, b / i)).ToSimple(); ;
                }
            }
            return new Fraction(a,b);
        }
    }
}
