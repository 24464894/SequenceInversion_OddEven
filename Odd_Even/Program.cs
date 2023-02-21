using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入序列:");
            string input = Console.ReadLine();
            string[] text = input.Split(',');
            int[] IntText = Array.ConvertAll(text, s => int.Parse(s));
            var EvenNumber = IntText.Where(x => x%2 == 0).ToList();
            Console.Write("奇數 :");
            foreach (var item in EvenNumber)
            {
                Console.Write(item);
                Console.Write(",");
            }
            var OddNumber = IntText.Where(x => x % 2 != 0).ToList();
            Console.Write("偶數:");
            foreach (var item in OddNumber)
            {
                Console.Write(item);
                Console.Write(",");
            }
        }
    }
}
