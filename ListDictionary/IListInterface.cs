using System.Collections.Generic;

namespace ListDictionary
{
    interface IListInterface
    {
        int SimpleFind(List<int> list, int number);
        int LinqFind(List<int> list, int number);

        int SimpleMax(List<int> list);
        int LinqMax(List<int> list);

        int SimpleMin(List<int> list);
        int LinqMin(List<int> list);

        void SimpleSort(List<int> list);
        void LinqSort(List<int> list);

        void SimpleReverce(List<int> list);
        void LinqReverce(List<int> list);
    }
}
