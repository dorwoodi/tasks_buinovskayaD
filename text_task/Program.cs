using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_task
{
    class Program

    { 
        static bool YnikalSymb( string text, char symb)
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

            string  a= System.IO.File.ReadAllText(@"C:\Users\buino_000\Desktop\new 2.txt");
            Console.WriteLine(a);
            a = a.Trim(new char[] { ',', '.', '-', '"', ')', '(' });
            //Cчитаем количество слов в исходном тексте

            string[] textArray = a.Split(new char[] { ' ' });
            Console.WriteLine("Колличество слов в тексте: " + textArray.Length);
            
            //Уникальных букв в первом слове
            string text=" ";
            for (int i = 0; i < text.Length; i++)
            {
                if (YnikalSymb(text,a[i]))
                text = text + a[i];
            }
            Console.WriteLine(text);


            Console.ReadKey();

        }
    }

}






