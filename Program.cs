using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftSocks = new Stack<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            var rightSocks = new Queue<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            var pairs = new List<int>();

            while (leftSocks.Count>0 && rightSocks.Count>0)
            {
                var leftOne = leftSocks.Peek();
                var rightOne = rightSocks.Peek();

                if (leftOne> rightOne)
                {
                    leftSocks.Pop();
                    rightSocks.Dequeue();

                    var sum = leftOne + rightOne;
                    pairs.Add(sum);
                }
                else if (leftOne == rightOne)
                {
                    leftSocks.Push(leftSocks.Pop()+1);
                    rightSocks.Dequeue();
                }
                else
                {
                    leftSocks.Pop();
                }
            }

            Console.WriteLine(pairs.Max(x=>x));
            Console.WriteLine(string.Join(" ",pairs));

        }
    }
}
