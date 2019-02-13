using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    class Message
    {
        /// <summary>
        /// Выводит слова длинной N символов
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="n">Длина слов</param>
        static public void CharCount(string message, int n)
        {
            string[] mes = ArrayFromString(message);

            for (int i = 0; i < mes.Length; i++)
            {
                if (mes[i].Length == n)
                {
                    Console.WriteLine($"<{mes[i]}>");
                }
            }
            
        }

        /// <summary>
        /// Удаляет из сообщения слова, оканчивающийся на указанную букву
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="last">Последняя буква</param>
        /// <returns>message</returns>
        static public string Remover(string message, char last)
        {
            string[] mess = ArrayFromString(message);

            for (int i = 0; i < mess.Length; i++)
            {
                if (mess[i][mess[i].Length - 1] == last)
                {
                    mess[i] = "";
                }
            }
            return string.Join(" ", mess);
        }


        /// <summary>
        /// Самое длинное слово сообщения
        /// </summary>
        static public string Max ="";

        /// <summary>
        /// Определяем саммое длинное слово сообщения
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static public string Maximum(string message)
        {
            
            string[] mess = ArrayFromString(message);

            for (int i = 0; i < mess.Length; i++)
            {
                if (mess[i].Length > Max.Length)
                {
                    Max = mess[i];
                }
            }
            return Max;
        }

        /// <summary>
        /// Самые длинные слова массива
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns>StringBuilder с самыми длинными сообщениями</returns>
        static public StringBuilder MaxString(string message)
        {
            string[] mess = ArrayFromString(message);
            Maximum(message);

            string words = "";
            foreach (var mes in mess)
            {
                if (mes.Length == Max.Length)
                {
                    words += $"{mes}, ";
                }
            }
            StringBuilder sb = new StringBuilder(words);
            return sb;
        }

        /// <summary>
        /// Проводит подщёт кол-ва повторов слов
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns>Dictionary</returns>
        static public Dictionary<string, int> Analyze(string message)
        {
            string[] mess = ArrayFromString(message);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var key in mess)
            {
                if (dic.ContainsKey(key))
                {
                    dic[key]++;
                }
                else
                {
                    dic.Add(key, 1);
                }
                    
            }
            return dic;
        }

        static private string[] ArrayFromString(string message)
        {
            Regex regex = new Regex(@"\w+");

            string[] Array = new string[regex.Matches(message).Count];

            int i = 0;

            foreach (var item in regex.Matches(message))
            {
                Array[i] = item.ToString();
                i++;
            }

            return Array;
        }


    }
}
