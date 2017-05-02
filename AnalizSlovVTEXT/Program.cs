using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizSlovVTEXT
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Фотосинтез.txt");


            //Cчитаем количество слов в исходном тексте
            string[] textWords = text.Split(new char[] { ' ', ',', '.', '—', '«', '»', '-', ':', '!', '?', ';' });
            Console.WriteLine("Количество слов: " + textWords.Length);

            int maxWord = 0, index = 0;

            for (int i = 0; i < textWords.Length; i++)
            {
                if (textWords[i].Length >= maxWord)
                {
                    maxWord = textWords[i].Length;
                    index = i;
                }

            }

            int kollMaxWords = 0;
            string slova = " ";
            for (int i = 0; i < textWords.Length; i++)
            {
                if (maxWord == textWords[i].Length)
                {
                    kollMaxWords++;
                    slova = textWords[i];
                    Console.Write("длинное слово: " + slova + "\r\n");
                }
            }

            Console.Write("Колличество самых длинных слов в тексте " + kollMaxWords + "\r\n");
            Console.Write("Колличество букв в самых длинных словах " + maxWord + "\r\n");


            int minWord = textWords[1].Length, index2 = 0;
            for (int i = 1; i < textWords.Length; i++)
            {
                if ((textWords[i].Length < minWord) && (textWords[i].Length != 0))
                {
                    minWord = textWords[i].Length;
                    index2 = i;
                }

            }
            int kollMinWords = 0;
            string slova2 = " ";
            for (int i = 0; i < textWords.Length; i++)
            {
                if (minWord == textWords[i].Length)
                {
                    kollMinWords++;
                    slova2 = textWords[i];
                    Console.Write("короткое слово: " + slova2 + "\r\n");
                }
            }
            Console.Write("Колличество самых коротких слов в тексте " + kollMinWords + "\r\n");
            Console.Write("Колличество букв в самых коротких словах " + minWord);

            Console.ReadKey();


        }
    }
}
       
    

