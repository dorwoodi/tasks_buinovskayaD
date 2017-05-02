using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Palindrom
{
    class Program
    {
        public static bool Palindromtest(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j])
                    return false;
            return true;

        }



        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\1234.txt");
            Console.WriteLine(text);
            string[] textWords = text.Split(new char[] { ' ', ',', '.', '—', '«', '»', '-' });

            for (int i = 0; i < textWords.Length; i++)
            {
                if (Palindromtest(textWords[i]))
                {
                    string slovaPalindromi = " ";
                    slovaPalindromi = textWords[i];
                    Console.WriteLine("Палиндром:" + "\r\n" + slovaPalindromi + "\r\n");
                }

                else
                {

                    Console.WriteLine(textWords[i] + " не палиндром ");
                }



            }
            Console.ReadKey();
        }
    }
}




