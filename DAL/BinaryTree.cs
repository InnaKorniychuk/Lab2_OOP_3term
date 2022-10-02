using System;
using System.Collections.Generic;
using System.Collections;


namespace DAL
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable
    {
        private BinaryTree<T> Left { get; set; }
        private BinaryTree<T> Right { get; set; }

        public T Root { get; set; }

        public BinaryTree(T node) { Root = node; }

        public void Insert(T item)
        {
            if (Root.CompareTo(item) > 0)
            {
                if (Left == null)
                    Left = new BinaryTree<T>(item);
                else
                    Left.Insert(item);
            }
            else
            {
                if (Right == null)
                    Right = new BinaryTree<T>(item);
                else
                    Right.Insert(item);
            }
        }

        public bool isInTree(T item)
        {
            if (item == null)
                return false;
            foreach (T node in this)
            {
                if (node.Equals(item))
                    return true;
            }
            return false;
        }
        public void Print()
        {
            foreach (T node in this)
            {
                Console.WriteLine(node.ToString());
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            if (Root != null)
            {
                yield return Root;

                if (Left != null)
                {
                    foreach (T item in Left)
                    {
                        yield return item;
                    }
                }

                if (Right != null)
                {
                    foreach (T item in Right)
                    {
                        yield return item;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
