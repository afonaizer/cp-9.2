using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bible = new List<string>(8);
            Fill(bible);
            Lover(bible);
            Spisok(bible);
            Upper(bible);
            Spisok(bible);
            Count(bible);
            bible.Add("Преступление и наказание");
            bible.Insert(0,"Детство");   
            Upper(bible);
            Spisok(bible);
            bible.RemoveAt(3);
            Spisok(bible);
            Reverse(bible);
            Console.ReadKey();
        }

        static void Fill(List<string> bible)
        {
            List<string> fill = new List<string>(6);
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"\nназвание книги {i + 1}: ");
                bible.Add(Console.ReadLine());
            }    
        }

        static void Spisok(List<string> item)
        {
            Console.WriteLine();
            for (int i = 0; i < item.Count; i++)
            {
                 Console.WriteLine(item[i]);
            }
        } 
        
        static void Reverse(List<string> rev)
        {
            Console.WriteLine();
            for (int i = rev.Count - 1; i >= 0; i--)
            {
                Console.Write($"{rev[i]}\n");
            }
        }

        static void Count(List<string> cnt)
        {
             int count = cnt.Count;
             Console.WriteLine($"\nКоличество книг в библиотеке : {count}");
        }    
        static void Upper(List<string> upp)
        {
             for (int i = 0; i < upp.Count; i++)
             {
                  upp[i] = upp[i].ToUpper();
             }
        }
        static void Lover(List<string> low)
        {
             for (int i = 0; i < low.Count; i++)
             {
                  low[i] = low[i].ToLower();
             }
        }
    }
}
