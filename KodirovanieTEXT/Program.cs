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
            string text = System.IO.File.ReadAllText(@"C:\Users\buino_000\Desktop\1234.txt");
            var litterMas = text.ToCharArray();
            foreach (var i in litterMas)
            {
                
                for (char c = 'а'; c < 'я'; c++)
                {
                    Random random = new Random();
                    int randomNumber;
                    randomNumber = random.Next(100);
                    int cx1 = (int)c;
                    int cx2= cx1 + randomNumber;
                    Console.WriteLine(c+" - "+cx2);
                }   
            }
            Console.ReadLine();
        }
    }
}
