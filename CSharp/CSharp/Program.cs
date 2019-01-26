using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program : Staff
    {
        public static string name;
        public static string surname;

        static void Main(string[] args)
        {

            #region L1H1
            /*
            //1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.

            NameSurname();

            Console.WriteLine("Укажите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите ваш рост(в сантиметрах):");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите ваш вес:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ваша анкета:");

            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) *используя вывод со знаком $.

            //Console.WriteLine(name+surname+'.'+age+'лет.'+height+'cm'+weight+'кг.');

            Console.WriteLine($"{name} {surname}.{age} лет. {height} cm. {weight:0,#} кг."); // Не придумал куда здесь использовать форматированный вывод
            Console.ReadLine();

            */
            #endregion

            #region L1H2
            /*
            //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах

            Console.WriteLine("Введите массу тела(в кг):");
            float m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите рост(в см):");
            float h = Convert.ToInt32(Console.ReadLine()) / 10f;

            float IMT = m / (h * h) * 100;
            Console.WriteLine($"Ваш ИМТ равен {IMT:0.##}.");
            Console.ReadLine();
            */
            #endregion

            #region L1H3
            /*
            // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            // б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

            Console.WriteLine("Введите координаты первой точки(x,y):");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки(x,y):");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = distance(x1,y1,x2,y2);

            Console.WriteLine($"Расстояние между точками равно: {r:F2}");
            Console.ReadLine();
            */
            #endregion

            #region L1H4

            // 4. Написать программу обмена значениями двух переменных.
            // а) с использованием третьей переменной;
            // б) *без использования третьей переменной.
            /*
            int a;
            int b;
            a = 5;
            b = 10;

            // a
            
            //int c;
            //c = a;
            //a = b;
            //b = c;            
            

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{a},{b}");
            Console.ReadLine();
            */
            #endregion

            #region L1H5
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организуйте в центре экрана
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

            /*
            int maxX = 120;
            int maxY = 25;
            Console.SetWindowSize(maxX, maxY);
            Console.SetBufferSize(maxX, maxY);

            NameSurname();

            Console.WriteLine("Введите ваш город:");
            string sity = Console.ReadLine();

            Console.Clear();
            string msg = $"{name} {surname}, г.{sity}";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Print(msg, (maxX / 2) - 1 - msg.Length, (maxY / 2) - 1);
            Pause();
            */
            
            #endregion

        }

        static double distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static void NameSurname()
        {
            Console.Clear();

            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            surname = Console.ReadLine();

            Console.Clear();
        }
        
    }
}
