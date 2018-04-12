using System.Collections.Generic;

namespace ListDictionary
{
    interface IDictionaryInterface
    {
        string SimpleFind(Dictionary<int, string> dictionary, int number);
        string LinqFind(Dictionary<int, string> dictionary, int number);

        int SimpleMax(Dictionary<int, string> dictionary);
        int LinqMax(Dictionary<int, string> dictionary);

        int SimpleMin(Dictionary<int, string> dictionary);
        int LinqMin(Dictionary<int, string> dictionary);

        void SimpleSort(Dictionary<int, string> dictionary);
        void LinqSort(Dictionary<int, string> dictionary);

        void SimpleReverce(Dictionary<int, string> dictionary);
        void LinqReverce(Dictionary<int, string> dictionary);
    }
}
