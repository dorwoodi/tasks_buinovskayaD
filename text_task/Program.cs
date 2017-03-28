using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\buino_000\Desktop\new2.txt");
            Console.WriteLine(text);

            //Cчитаем количество слов в исходном тексте

            string[] textArray = text.Split(new char[] { ' ' });
            Console.WriteLine("Колличество слов в тексте: " + textArray.Length);

            //Ищем наиболее часто встречаемую букву в тексте
            int count = 0;
            char letter = ' '; // это будет наиболее часто встречающийся символ
            for (char c = 'а'; c < 'я'; c++) // цикл по  алфавиту
            {
                int tmp = 0; // количество повторений в тексте текущей буквы
                for (int i = 0; i < text.Length; i++) // цикл по всему тексту для подсчета количества текущего символа (char c - текущий символ)
                    if (text[i] == c) // если нашли текущий символ, инкрементим счетчик
                        tmp++;
                if (tmp > count)
                {
                    count = tmp;
                    letter = c;
                }
            }

            Console.WriteLine("Чаще всего встречается буква " + letter + ", ее в тексте " + count + " штук.");

            //Найдем сколько всего букв в исходном тексте

            int lettersIntext = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Substring(i, 1) != " ")
                    lettersIntext++;
            }
            Console.WriteLine("Количество букв равно {0}", lettersIntext);

            //Найдем процентное отношение частовстречаемой буквы 
            double procentletter = 0;
            procentletter = (count * 100) / lettersIntext;
            Console.WriteLine("Процентное отношение частовстречаемой буквы к остальным равно примерно " + procentletter + "%");
            Console.ReadKey();

        }
    }

}






