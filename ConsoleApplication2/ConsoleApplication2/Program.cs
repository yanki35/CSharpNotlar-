using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();

            //numbers.Add(1);
            //numbers.AddRange(new int[] { 2, 3, 4 });

            //Console.WriteLine(numbers.Count);

            //Console.Clear();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine("{0} = {1}", i numbers[i]);
            //}

            //int[] array = new int[2];
            //array[0] = 3;
            //array[1] = 5;

            //List<int> list = new List<int>(array);

            //Console.WriteLine("{0} tane eleman yazdıracağım", list.Count);

            //foreach (var elm in list)
            //{
            //    Console.Write(elm + " ");
            //}

            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });

            //numbers.RemoveAt(0);       // girilen index siler
            //numbers.Remove(8);         // girilen değer siler, birden fazla ise ilk değeri siler
            //numbers.RemoveRange(3, 2); // aralık siler

            //bool varmi = numbers.Contains(13);

            bool varmi = true;

            while (varmi)
            {
                if(numbers.Contains(8))
                {
                    numbers.Remove(8);
                }
                else
                {
                    varmi = false;
                }
            }
            foreach (var item in numbers)
            {
                Console.Write("\n\t" + item);
            }
            {

            }

            foreach (var item in numbers)
            {
                Console.WriteLine("\n\t" + item);
            }
            {

            }
        }
    }
}
