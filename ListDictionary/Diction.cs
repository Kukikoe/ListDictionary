using System;
using System.Collections.Generic;
using System.Linq;

namespace ListDictionary
{
    class Diction : IDictionaryInterface
    {
        public string SimpleFind(Dictionary<int, string> dictionary, int number)
        {
            string index = String.Empty;
            foreach (KeyValuePair<int, string> dic in dictionary)
            {
                if (dic.Key == number)
                {
                    index = dic.Value;
                }
            }
            return index;
        }
        public string LinqFind(Dictionary<int, string> dictionary, int number)
        {

            var item = (from d in dictionary
                        where d.Key == number
                        select d.Value).FirstOrDefault();

            return item;
        }

        public int SimpleMax(Dictionary<int, string> dictionary)
        {
            int max = 0;
            foreach (KeyValuePair<int, string> dic in dictionary)
            {
                if (dic.Key > max)
                {
                    max = dic.Key;
                }
            }
            return max;
        }
        public int LinqMax(Dictionary<int, string> dictionary)
        {
            return dictionary.Keys.Max();
        }

        public int SimpleMin(Dictionary<int, string> dictionary)
        {
            int min = dictionary.Keys.First();
            foreach (KeyValuePair<int, string> dic in dictionary)
            {
                if (dic.Key < min)
                {
                    min = dic.Key;
                }
            }
            return min;
        }
        public int LinqMin(Dictionary<int, string> dictionary)
        {
            return dictionary.Keys.Min();
        }

        public void SimpleSort(Dictionary<int, string> dictionary)
        {
            int temp = 0;
            int[] keys = dictionary.Keys.ToArray();
            for (int i = 0; i < dictionary.Count; i++)
            {
                for (int j = i + 1; j < dictionary.Count; j++)
                {
                    if (keys[i] > keys[j])
                    {
                        temp = keys[i];
                        keys[i] = keys[j];
                        keys[j] = temp;
                    }
                }
            }
            foreach (var sort in keys)
            {
                Console.Write(" " + sort);
            }
        }
        public void LinqSort(Dictionary<int, string> dictionary)
        {
            var sortedElements = dictionary.Keys.OrderBy(x => x);
            foreach (var sort in sortedElements)
            {
                Console.Write(" " + sort);
            }
        }

        public void SimpleReverce(Dictionary<int, string> dictionary)
        {
            var sortedElements = dictionary.Keys.OrderBy(x => x);
            int temp = 0;
            int[] keys = sortedElements.ToArray();
            for (int i = 0, j = dictionary.Count - 1; i < j; i++, j--)
            {
                temp = keys[i];
                keys[i] = keys[j];
                keys[j] = temp;
            }
            foreach (var revercesort in keys)
            {
                Console.Write(" " + revercesort);
            }
        }
        public void LinqReverce(Dictionary<int, string> dictionary)
        {
            var sortedElements = dictionary.Keys.OrderByDescending(x => x);
            foreach (var revercesort in sortedElements)
            {
                Console.Write(" " + revercesort);
            }
        }
    }
}
