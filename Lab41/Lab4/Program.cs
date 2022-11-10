using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Dynamic;
using System.Runtime.ExceptionServices;
using System.Threading;
using Lab4;


namespace Proga
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введит предложение, где каждое слово разделено симвлом <_>: ");
            Lab41 resault = new Lab41(Console.ReadLine());
            Console.WriteLine("\nВсе комбинации:");
            foreach (var s in resault.MainFunction())
            {
                Console.WriteLine(s);
            }
        }
    }
}