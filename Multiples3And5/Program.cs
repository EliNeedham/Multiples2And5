using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jared - this is the worst kind of math.................

            //at first I started out thinking about counting down from 1000 and looking to see how many times 3 or 5 could go into each number - putting that number into a variable or something or adding them up as I went and the combinig the two totals at the end. 
            //I forgot about modulus entirely

            int threes = 0;
            int fives = 0;
            for (int i = 999; i > 0; i -= 3)
            {
                threes = i + threes;
            }

            for (int i = 1000; i > 0; i -=5)
            {
                fives = i + fives;
            }

            int elizardSum = fives + threes;
            Console.WriteLine(elizardSum);

            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
