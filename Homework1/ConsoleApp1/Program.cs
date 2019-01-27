using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Александр Емелёв / MrHeadsh0t 
        static void Main()
        {

            #region L2H1

            //1. Написать метод, возвращающий минимальное из трех чисел.

            /*
             
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            double c = Convert.ToDouble(Console.ReadLine());


            double Max = maxNumber(a, b, c);

            Staff.Beauti();
            Console.WriteLine($"Самое большое число: {Max}");
            Staff.Pause();
            Staff.cs();
            
            */

            #endregion

            #region L2H2


            //2. Написать метод подсчета количества цифр числа.

            /*

            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());

            Staff.Beauti();
            Console.WriteLine($"Длина вашего числа : {numberLength(number)}");
            Staff.Pause();
            Staff.cs();
          
            */

            #endregion

            #region L2H3

            //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            /*

            int summ = 0;

            while (true)
            {
                Console.WriteLine("Введите число:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0) break;
                else if ((num % 2 == 1) && (num > 0))
                {
                    summ += num;
                }
                Console.Clear();
            }

            Staff.Beauti();
            Console.WriteLine($"Сумма всех нечётных положительных чисел: {summ}");
            Staff.Pause();
            Staff.cs();

            */

            #endregion

            #region L2H4

            //4.Реализовать метод проверки логина и пароля.На вход подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.

            /*

            int count = 0;
            bool res;

            do
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();

                res = logCheck(login, password);

                if (!res)
                {
                    Staff.Beauti();
                    Console.WriteLine("Что-то не так...");
                    Staff.cs();
                }
                else break;

                count++;

            } while (count != 3);

            Staff.Beauti();
            if (res)
            {
                Console.WriteLine("Добро пожаловать!");
                Staff.Pause();
            }
            else
            {
                Console.WriteLine("Вы ввели пароль неправильно 3 раза.Ввод заблокирован");
                Staff.Pause();
                return;
            }

            */

            #endregion

            #region L2H5

            //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            // За норму ИМТ взято 20 - 25;

            /*

            Console.WriteLine("Введите массу человека(в кг):");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост человека(в см):");
            double height = Convert.ToDouble(Console.ReadLine());
            height = height / 100; // Рост в метрах 

            double BMI = (weight / (height * height));

            Staff.Beauti();
            Console.Write($"Ваш ИМТ: {BMI:0.#}. ");

            if (BMI > 25)
            {
                double lost1 = weight - (25 * height * height);
                double lost2 = weight - (20 * height * height);
                Console.WriteLine($"Ваш ИМТ слишком большой, вам нужно похудеть на {lost1:0.#} - {lost2:0.#} кг");
            } else if ( BMI < 20)
            {
                double take1 = (20 * height * height) - weight;
                double take2 = (25 * height * height) - weight;
                Console.WriteLine($"Ваш ИМТ слишком низкий, вам нужно набрать {take1:0.#} - {take2:0.#} кг");
            } else
            {
                Console.WriteLine("У вас нормальный ИМТ.");
            }

            Staff.Pause();

            */

            #endregion

            #region L2H6

            //6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            //Хорошим называется число, которое делится на сумму своих цифр. 
            //Реализовать подсчет времени выполнения программы, используя структуру DateTime.

            /*

            var TimeStart = DateTime.Now;


            int count = 0;

            int iMin = 1;
            int iMax = 1000000000;

            for (int i = iMin; i <= iMax; i++)
            {
                int summ = 0;
                int num = i;

                while (num >= 1)
                {
                    summ += num % 10;
                    num /= 10;
                }


            
                if ((i % summ) == 0)
                {
                    count++;
                }
            }
            
            Console.WriteLine($"В диапазоне от {iMin} до {iMax:### ### ### ###} :  {count} «Хороших» чисел");
            var TimeEnd = DateTime.Now;
            Console.WriteLine($"Ваша программа работала: ({(TimeEnd - TimeStart)})" ); // Так и не понял как форматировать TimeSpan.
            Staff.Pause();
            // Считало 00:01:58, надо обновлять Пк ;(

            */

            #endregion

            #region L2H7

            //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            /*

            int a = 1;
            int b = 100; // Включительно

            Staff.Beauti();
            //printRecursive(a, b);
            Console.WriteLine($"Сумма чисел от {a} до {b} = {Sum(a, b)}"); 
            Staff.Pause();

            */

            #endregion

        }

        #region methods
        static private double numberLength(double num)
        {
            int length = 0;

            while (Math.Abs(num) >= 1)
            {
                num = num / 10;
                length++;
            }
            return length;
        }

        static private double maxNumber(double a, double b, double c)
        {
            if (a > b) return a;
            else if (b > c) return b;
            else return c;
        }

        static private bool logCheck(string login, string password)
        {
            if ((login == "root") && (password == "GeekBrains")) return true;
            else return false;
        }

        static private void printRecursive(int a, int b)
        {
            Console.WriteLine(a);
            a++;

        }

        public static int summary = 0;
        static private int Sum(int a, int b)
        {

            if (a <= b)
            {
                summary += a;
                Sum(a + 1, b);
            }
            return summary;
        }
        #endregion
    }
}
