using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region L5H1

            /*

            // 1.Создать программу, которая будет проверять корректность ввода логина.
            //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            // а) без использования регулярных выражений;
            // б) с использованием регулярных выражений.


            Console.WriteLine("Введите логин:");
            string userInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            //a

            Regex reg = new Regex(@"\b[a-zA-Z]{1}[a-zA-z0-9]{1,9}\b");
            if (reg.IsMatch(userInput))
            {
                Console.WriteLine("Логин введён верно");
            }
            else
            {
                Console.WriteLine("Логин введён неверно");
            }


            //b

            bool t = false;
            for (int i = 0; i <9; i++)
            {
                if (char.IsDigit(userInput[0])  || userInput.Length > 10)
                {
                    t = true;
                    break;
                }
            }
            if (t)
            {
                Console.WriteLine("Логин введён неверно");
            }
            else
            {
                Console.WriteLine("Логин введён верно");
            }
            Console.ReadLine();

            */

            #endregion

            #region L5H2

            /*

            string str = @"Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения,  которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            д) ***Создать метод, который производит частотный анализ текста.
            В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
            Здесь требуется использовать класс Dictionary.";

            
            int n = 5;
            char rm = 'е';
            Dictionary<string, int> dic = Message.Analyze(str);

            Console.WriteLine($@"Слова содержащие {n} букв:");
            Message.CharCount(str, 5);
            Console.WriteLine();

            Console.WriteLine($@"Новое сообщение без слов оканчивающихся на {rm}: 
            «{ Message.Remover(str, rm)}»");
            Console.WriteLine();

            Console.WriteLine($@"Саммое длинное слово:
            «{Message.Maximum(str)}»");
            Console.WriteLine();

            Console.WriteLine($@"Саммые длинные слова массива:
            «{Message.MaxString(str).ToString()}»  ");
            Console.WriteLine();

            Console.WriteLine($@"Количество повторов слов:");
            foreach (var item in dic)
            {
                Console.WriteLine($" Слово \"{item.Key}\" повторилось {item.Value} раз");
            }
            Console.WriteLine();


            */
            #endregion

            #region L5H3

            /*

            //3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
            //а) с использованием методов C#;
            //б) *разработав собственный алгоритм.
            //Например:
            //badc являются перестановкой abcd.
            string message1 = "< "+"badc"+" >";
            string message2 = "< "+"abcd"+" >";
            if (Compare(message1,message2))
            {
                Console.WriteLine($@"{message1} является перестановкой {message2}");
            }
            else
            {
                Console.WriteLine($@"{message1} НЕ является перестановкой {message2}");
            }

            */
            #endregion

            #region L5H4








            #endregion



            Console.ReadLine();



        }

        static bool Compare(string message1,string message2)
        {
            char[] mesArr1 = message1.ToCharArray();
            char[] mesArr2 = message2.ToCharArray();

            Dictionary<char, int> dic1 = CharCount(mesArr1);
            Dictionary<char, int> dic2 = CharCount(mesArr2);

            int trueCount = 0;

            foreach (var key in dic1.Keys)
            {
                if (dic2.ContainsKey(key) && (dic1[key] == dic2[key]) && (dic1.Count == dic2.Count))
                {
                    trueCount++;
                }
            }

            if (trueCount == dic1.Count)
            {
                return true;
            }
            else
            {
                return false;
            }




        }

        static Dictionary<char,int> CharCount(char[] charArr)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var mes in charArr)
            {
                if (dic.ContainsKey(mes))
                {
                    dic[mes]++;
                }
                else
                {
                    dic.Add(mes, 1);
                }
            }
            return dic;
        }
    }
}
