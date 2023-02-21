using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入序列:");
            string input = Console.ReadLine();
            string[] text = input.Split(',');

            var number = text.OrderByDescending(x => x).ToList();
            Console.Write("結果序列");
            foreach (var item in number)
            {
                Console.Write(item);
                Console.Write(",");
            }
            Console.ReadLine();
        }
      
        
    }
}
