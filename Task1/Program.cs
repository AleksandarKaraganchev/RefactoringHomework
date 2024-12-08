using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> originalList = new LinkedList<int>();
            originalList.AddLast(1);
            originalList.AddLast(2);
            originalList.AddLast(3);
            originalList.AddLast(4);
            originalList.AddLast(5);

            var evenList = SplitList(originalList, "even");
            var oddList = SplitList(originalList, "odd");

            Console.WriteLine("Списък с четни числа: ");
            PrintList(evenList);
            Console.WriteLine("Списък с нечетни числа: ");
            PrintList(oddList);
        }

        private static List<int> SplitList(LinkedList<int> originalList, string EvenOrOdd)
        {
            List<int> listSplit = new List<int>();
            var currentElement = originalList.First;
            while (currentElement != null)
            {
                if (EvenOrOdd == "even" && currentElement.Value % 2 == 0)
                {
                    listSplit.Add(currentElement.Value);
                }
                if (EvenOrOdd == "odd" && currentElement.Value % 2 != 0)
                {
                    listSplit.Add(currentElement.Value);
                }
                currentElement = currentElement.Next;
            }
            return listSplit;
        }

        static void PrintList(List<int> numberList)
        {
            foreach (var item in numberList)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}
