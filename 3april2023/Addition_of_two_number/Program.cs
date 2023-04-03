using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_of_two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your frist number");
            int fristNO = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your second number");
            int secondNO = int.Parse(Console.ReadLine());

            int sum = fristNO + secondNO;
            Console.WriteLine("total:{0}",sum);

            Console.ReadLine();
        }
    }
}
