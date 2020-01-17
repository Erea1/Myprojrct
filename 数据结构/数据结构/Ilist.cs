using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构
{
    interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        T this[int index] { get; }
        T GetEle(int index);
        int Locate(T value);

    }
}
