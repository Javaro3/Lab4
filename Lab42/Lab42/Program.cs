using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите текст: ");
            string userString = Regex.Replace(Console.ReadLine(), "[?!]", ".");
            string[] strings = userString.Split('.');
            Console.WriteLine("Введите слово: ");
            string word = Console.ReadLine();
            foreach (var s in strings)
            {
                string[] tmp = s.Split(' ');
                bool wordExis = false;
                int i = 0;
                while(i < tmp.Length && !wordExis)
                {
                    if ((tmp[i].ToLower()).Contains(word) && word.Length == tmp[i].Length)
                    {
                        wordExis = true;
                    }
                    i++;
                }

                if (wordExis)
                {
                    sb.Append(s + ".");
                }
            }
            Console.WriteLine(sb);
        }
    }
}