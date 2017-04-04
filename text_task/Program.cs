using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_task
{
    class Program

    {   //Метод, который считает процент символа в тексте
        static double PercentOfALetter(char[] textSymbols, char letter)
        {
            double procent = 0, numberOfLetters = 0;
            foreach (var i in textSymbols)
            {
                if (i == letter)
                {
                    numberOfLetters = numberOfLetters + 1;
                }

                procent = numberOfLetters / (textSymbols.Length / 100);
            }
            return procent;
        }
        //Метод, который определяет уникальность символа
        static bool UnikalSymb(string text, char symb)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (symb == text[i])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\buino_000\Desktop\new 2.txt");
            Console.WriteLine(text);

            //Cчитаем количество слов в исходном тексте
            string[] textWords = text.Split(new char[] { ' ', ',', '.', '—', '«', '»', '-' });
            Console.WriteLine("Количество слов: " + textWords.Length);

            //Считаем количество символов в исходном тексте
            char[] textSimbols = text.ToCharArray();
            Console.WriteLine("Количество символов: " + textSimbols.Length);

            //Переведем текст в нижний регистр
            string lowerText = text.ToLower();
            Console.WriteLine("Текст в нижнем регистре" + lowerText);

            //Поиск уникальных букв в тексте
            string unicalChar = "";
            foreach (var i in lowerText)
            {
                {
                    if (unicalChar.Length == 0)
                    {
                        unicalChar = unicalChar + i;
                    }
                    else
                    {
                        bool search = UnikalSymb(unicalChar, i);
                        if (search)
                        {
                            unicalChar = unicalChar + i;

                        }
                    }

                }

                Console.WriteLine("Уникальные символы: " + unicalChar);

            }
            foreach (char i in unicalChar)
            {
                double procent = PercentOfALetter(textSimbols, i);
                Console.WriteLine("Процент символа \"{0}\" в тексте, равен : {1}%", i, procent);

                Console.ReadKey();

            }
        }

    }
}






