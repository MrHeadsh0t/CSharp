using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork4
{
    class Program
    {
        struct Account
        {
            public string Login;
            public string Password;
        }

        static void Main(string[] args)
        {
            #region L4H1

            //Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива. 
            //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

            /*
            int answer=0;

            // создаём массив и наполняем его
            int[] array = new int[20];
            Random r = new Random();

            for (int i=0;i < array.Length; i++)
            {
                array[i] = r.Next(-10000, 10000);
                Console.Write($"{array[i]},  ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length - 1;i++)
            {
                if (((array[i] %  3) == 0) || ((array[i+1] % 3) == 0))
                {
                    answer++;
                }
            }

            Console.WriteLine($"Ответ: {answer}");
            Console.ReadLine();
            */

            #endregion

            #region L4H2

            //2. а) Дописать класс для работы с одномерным массивом. 
            //Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
            //Создать свойство Sum, которые возвращают сумму элементов массива, 
            //метод Inverse, меняющий знаки у всех элементов массива,
            //метод Multi, умножающий каждый элемент массива на определенное число,
            //свойство MaxCount, возвращающее количество максимальных элементов. <--- !!!Не понял!!!
            //В Main продемонстрировать работу класса.
            //б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.


            /*

            // Создаём массивы
            Massive arr = new Massive(10, 1, 2);
            
            //Создаём массив из файла
            Massive brr = new Massive(@"input.txt"); // @"c:\temp\MyTest.txt"

            Console.WriteLine("Первый массив:");
            arr.Print();
            

            Console.WriteLine("Второй массив:");
            brr.Print();

            //Записываем массив в файл
            brr.WriteToFile(@"output.txt");
            
            //Нб член массива
            int Max = brr.MaxCount();
            Console.WriteLine($"Во втором массиве самый большой член( {brr.Max} ) повторяется {Max} раз.");
            Console.WriteLine();

            //Сумма всех членов массива
            Console.WriteLine($"Сумма всех членов второго массива равна: {brr.Summ()}");
            Console.WriteLine();

            //Инверсия
            Massive a = brr;
            a.Inverse();
            Console.WriteLine("Инвретированные членны второго  массива:");
            a.Print();

            //Умножение
            int mult = 20;
            Console.WriteLine($"Умножение первого массива на {mult} :");
            Massive b = arr;
            b.Multi(Convert.ToInt32(Console.ReadLine()));
            b.Print();
            





            Console.ReadLine();

            */

            #endregion


            #region L4H3
            //3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
            //Создайте структуру Account, содержащую Login и Password.

            Account acc = new Account();
            string[] Data = File.ReadAllLines(@"login.txt");

            acc.Login = Data[0];
            acc.Password = Data[1];

            int tryCount = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            do
            {
                
                Console.WriteLine("Пожалуйста введите логин:");
                string userLog = Console.ReadLine();

                Console.WriteLine("Пожалуйста введите пароль:");
                string userPass = Console.ReadLine();

                if (userLog == acc.Login && userPass == acc.Password)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Что-то не так...");
                    Console.ReadLine();
                    Console.Clear();
                    tryCount++;
                }


            } while (tryCount != 3);

            if(tryCount == 3)
            {
                Console.WriteLine("Ввод заблокирован");
            }
            else
            {
                Console.WriteLine("Добро пожаловать!");
            }
            Console.ReadLine();

            #endregion







        }
    }
}
