using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构
{/// <summary>
/// 单链表的节点
/// </summary>
/// <typeparam name="T"></typeparam>
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node()
        {
            data = default(T);
        }
        public Node(T value)
        {
            data = value;
            next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.data = value;
            this.next = next;
        }

        public Node(Node<T> next)
        {
            this.next = next;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
