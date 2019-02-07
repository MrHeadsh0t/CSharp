using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork4
{
    class Massive
    {
        /// <summary>
        /// Массив 
        /// </summary>
        public int[] arr;

        /// <summary>
        /// Создать массив
        /// </summary>
        /// <param name="len">Длина массива</param>
        /// <param name="start">Старт массива</param>
        /// <param name="step">шаг массива</param>
        public Massive(int len, int start, int step)
        {
            arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = start + step * i;
            }
        }
        /// <summary>
        /// Взять массив из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public Massive(string path)
        {
            //Все члены массива записывать через ' '
            string mes = File.ReadAllText(path);
            string[] mesMass = mes.Split(' ');
            arr = new int[mesMass.Length];
            for (int i = 0; i < mesMass.Length; i++)
            {
                arr[i] =Convert.ToInt32( mesMass[i]);
            }
        }

        /// <summary>
        /// Записывает массив в файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public void WriteToFile(string path)
        {
            File.WriteAllText(path, string.Join(" ", arr));
        }

        public int Max = 0;

        /// <summary>
        /// Ищет количество самых больших членов массива
        /// </summary>
        /// <returns>int</returns>
        public int MaxCount()
        {
            int Count=0;

            //Определяем самый большой член массива
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max) Max = arr[i];
            }

            // Ищем ещё самые большие члены
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == Max) Count++;
            }
            return Count;
        }

        /// <summary>
        /// Сумма всех членов массива
        /// </summary>
        /// <returns>int</returns>
        public int Summ()
        {
            int sum = 0;
            foreach (var x in arr)
            {
                sum += x;
            }
            return sum;
        }

        /// <summary>
        /// Инвертирует все члены массива
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0 - arr[i];
            }
        }

        /// <summary>
        /// Умножает все члены массива
        /// </summary>
        /// <param name="multip">Множитель</param>
        public void Multi(int multip)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multip;
            }
        }

        /// <summary>
        /// Выводит массив в консоль
        /// </summary>
        public void Print()
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}   ");
                
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
