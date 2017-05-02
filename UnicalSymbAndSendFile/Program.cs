using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicalSymbAndSendFile
{
    class Program
    {
        static bool UnikalSymb(string text, char symb)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (symb == text[i])
                    return false;
            }
            return true;
        }
        static int NumOfSymbolsInText(char symb, string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symb)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
           
                string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Фотосинтез.txt");
                string lowerText = text.ToLower();
                Console.WriteLine(lowerText);


                int count = 0;
                char letter = ' '; // это будет наиболее часто встречающийся символ 
                for (char c = 'а'; c < 'я'; c++) // цикл по алфавиту 
                {
                    int tmp = 0; // количество повторений в тексте текущей буквы 
                    for (int i = 0; i < lowerText.Length; i++) // цикл по всему тексту для подсчета количества текущего символа (char c - текущий символ) 

                        if (text[i] == c) // если нашли текущий символ, инкрементим счетчик 
                            tmp++;
                    Console.WriteLine(c + " - " + tmp);
                    if (tmp > count)
                    {
                        count = tmp;
                        letter = c;
                    }
                    System.IO.File.AppendAllText(@"C:\Users\student\Desktop\12344321.txt", c + ";" + tmp + "\r\n");
                }


                Console.ReadKey();

            }
        }

    }

    

