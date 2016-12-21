using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<char> alfabe = new List<char>();
            //for (char i = 'a' ; i <= 'z'  ; i++)
            //{
            //    alfabe.Add(i);
            //}

            //alfabe.Reverse();
            //foreach (var item in alfabe)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();

            List<string> isimler = new List<string>();

            isimler.Add("Hakan");
            isimler.AddRange(new string[] { "İrfan", "Aytekin", "Cemal", "Merve", "Yankı" });

            isimler.Sort();
            isimler.Reverse();

            foreach (var item in isimler)
            {
                Console.WriteLine("\t" + item);
            }
            Console.ReadKey();
        }
    }
}
