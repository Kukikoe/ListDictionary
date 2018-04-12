using System;
using System.Collections.Generic;
using System.Linq;

namespace ListDictionary
{
    class Schedule : IListInterface
    {
        public int SimpleFind(List<int> list, int number)
        {
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    index = i;
                }
                else
                {
                    Exist();
                    break;
                }
            }
            return index;
        }
        public void Exist()
        {
            Console.WriteLine( "\nYour number doesn't exist");
        }
        public int LinqFind(List<int> list, int number)
        { 
            return list.FindIndex(x => x == number);
        }

        public int SimpleMax(List<int> list)
        {
            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
        public int LinqMax(List<int> list)
        {
            //var itemMaxHeight = list.Max(y => y);
            return list.Max();
        }
        public int SimpleMin(List<int> list)
        {
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }
        public int LinqMin(List<int> list)
        {
            return list.Min();
        }

        public void SimpleSort(List<int> list)
        {
            int temp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            foreach (int sortlist in list)
            {
                Console.Write(" " + sortlist);
            }

        }
        public void LinqSort(List<int> list)
        {
            //list.Sort();
            list = list.OrderBy(x => x).ToList();
            foreach (int sortlist in list)
            {
                Console.Write(" " + sortlist);
            }
        }

        public void SimpleReverce(List<int> list)
        {
            int temp = 0;
            for (int i = 0, j = list.Count-1; i < j; i++, j--)
            {
                temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
            foreach (int revercelist in list)
            {
                Console.Write(" " + revercelist);
            }
        }
        public void LinqReverce(List<int> list)
        {
            list = list.OrderByDescending(x => x).ToList();
            //list.Reverse();
            foreach (int revercelist in list)
            {
                Console.Write(" " + revercelist);
            }
        }
    }
}
