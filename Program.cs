using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Я Влад. Тут є дві крапки. Ось остання.Привіт";
            int lastDotIndex = s.LastIndexOf('.');
            int countAfterLastDot = s.Length - lastDotIndex - 1;
            Console.WriteLine("Кількість символів після останньої точки: " + countAfterLastDot);


        }
    }
}