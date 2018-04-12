using System;
using System.Collections.Generic;

namespace ListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 12, 5, 23, 6, 1, 7 };
            Schedule schedule = new Schedule();
            Console.WriteLine("Our list:");
            foreach (int sortlist in list)
            {
                Console.Write(" " + sortlist);
            }
            Console.WriteLine("\n\nEnter value: ");
            string number = Console.ReadLine();
            Console.WriteLine("Your value is at the index: " + schedule.SimpleFind(list, int.Parse(number)));
            Console.WriteLine("Your value is at the index (LINQ): " + schedule.LinqFind(list, int.Parse(number)));

            Console.WriteLine("\nMax value: " + schedule.SimpleMax(list));
            Console.WriteLine("Max value (LINQ): " + schedule.LinqMax(list));
            Console.WriteLine("Min value: " + schedule.SimpleMin(list));
            Console.WriteLine("Min value (LINQ): " + schedule.LinqMin(list));

            Console.WriteLine("\nBubble sort:");
            schedule.SimpleSort(list);
            Console.WriteLine("\nSort with LINQ:");
            schedule.LinqSort(list);

            Console.WriteLine("\n\nSimple reverce:");
            schedule.SimpleReverce(list);
            Console.WriteLine("\nReverce with LINQ:");
            schedule.LinqReverce(list);

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(3, "three");
            dictionary.Add(1, "one");
            dictionary.Add(5, "five");
            dictionary.Add(9, "nine");
            dictionary.Add(14, "fourteen");
            dictionary.Add(20, "tventy");
            dictionary.Add(6, "six");

            Diction diction = new Diction();
            Console.WriteLine("\n\n" + new String('#', 50));
            Console.WriteLine("\nOur dictionary:");
            foreach (KeyValuePair<int, string> entry in dictionary)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("\nEnter key: ");
            number = Console.ReadLine();
            Console.WriteLine("Your value is: " + diction.SimpleFind(dictionary, int.Parse(number)));
            Console.WriteLine("Your value is (LINQ): " + diction.LinqFind(dictionary, int.Parse(number)));

            Console.WriteLine("\nMax value: " + diction.SimpleMax(dictionary));
            Console.WriteLine("Max value (LINQ): " + diction.LinqMax(dictionary));
            Console.WriteLine("Min value: " + diction.SimpleMin(dictionary));
            Console.WriteLine("Min value (LINQ): " + diction.LinqMin(dictionary));

            Console.WriteLine("\nBubble sort:");
            diction.LinqSort(dictionary);
            Console.WriteLine("\nSort with LINQ:");
            diction.SimpleSort(dictionary);

            Console.WriteLine("\n\nSimple reverce:");
            diction.SimpleReverce(dictionary);
            Console.WriteLine("\nReverce with LINQ:");
            diction.LinqReverce(dictionary);

            Console.ReadKey();
        }
    }
}
