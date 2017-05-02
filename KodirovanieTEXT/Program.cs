using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodirovanieTEXT
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\1234.txt");
            string Text1 = text.ToLower();
            char[] Text2 = new char[Text1.Length];
            char[] Text3 = new char[Text1.Length];
            char[] Text4 = new char[Text1.Length];
            int[] Chisla = new int[Text1.Length];
            for (int i = 0; i < Text1.Length; i++)
            {
                Text2[i] = Text1[i];

            }


            Random random = new Random();
            int randomNumber;


            for (int i = 0; i < Text2.Length; i++)
            {
                randomNumber = random.Next(9);
                Chisla[i] = randomNumber;
                int cx1 = (int)Text2[i];
                int cx2 = cx1 + randomNumber;
                Text3[i] = (char)cx2;

            }

            Console.WriteLine(Text3);

            for (int i = 0; i < Text2.Length; i++)
            {

                int cx1 = (int)Text3[i];

                int cx3 = cx1 - Chisla[i];
                int cx4 = (char)cx3;
                Text4[i] = (char)cx4;
                Console.WriteLine(Chisla[i] + " - число кодировки каждой буквы");

            }
            Console.WriteLine(Text4);

            Console.ReadLine();
        } 
            
    }
}
