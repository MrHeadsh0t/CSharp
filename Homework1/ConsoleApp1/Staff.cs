using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Staff
    {
        ///<summary>
        ///Выводит текст на данных координатах
        ///</summary>
        static public void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(msg);
        }

        /// <summary>
        /// Очищает консоль и ставит жёлтый цвет текста
        /// </summary>
        static public void Beauti()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        /// <summary>
        /// Очищает консоль и выбранный цвет текста
        /// </summary>
        /// <param name="color">Цвет текста</param>
        static public void Beauti(ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;
        }

        /// <summary>
        /// Устанавливает стандартный цвет
        /// </summary>
        static public void bReset()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Пауза на 300 миллисекунд
        /// </summary>
        static public void Pause()
        {
            Thread.Sleep(300);
            Console.ReadLine();
        }

        /// <summary>
        /// Пауза на установленное количество миллесекунд
        /// </summary>
        /// <param name="ms">Количество миллисекунд</param>
        static public void Pause(int ms)
        {
            Thread.Sleep(ms);
            Console.ReadLine();
        }
        
        /// <summary>
        ///  Очищает консоль
        /// </summary>
        static public void cs()
        {
            Console.Clear();
            Console.ReadLine();
            bReset();
            Console.SetCursorPosition(0, 0);
        }
    }
}
