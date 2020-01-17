using System;

namespace 数据结构
{
    class SeqList<T>:IListDS<T>
    {
        private T[] data;//用来存储数据
        private int count = 0;//表示存了多少数据

        public SeqList(int size)//最大容量
        {
            data = new T[size];
            count = 0;
        }

        public SeqList():this(10)//默认构造函数 容量是10
        {
            
        }

        public int GetLength()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

       

        public void Add(T item)
        {
            if (count==data.Length)//说明当前数组已经存满
            {
                Console.WriteLine("当前数据表已存满 不允许在存入");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        public void Insert(T item, int index)
        {
            for (int i = count-1; i >=index; i--)
            {
                data[i + 1] = data[i];
            }

            data[index] = item;
        }

        public T Delete(int index)
        {
            T temp = data[index];
            for (int i = index+1; i <count; i++)
            {
                data[i - 1] = data[i];
            }

            count--;
            return temp;
        }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        public T GetEle(int index)
        {
            if (index>=0&&index<=count)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }

        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
            //throw new NotImplementedException();
        }
    }
}
