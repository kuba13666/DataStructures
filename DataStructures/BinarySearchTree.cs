using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinarySearchTree<T>
    {
        public BinarySearchTreeNode<T> root;

        public BinarySearchTreeNode<T> SearchForANode(T data)
        {
            var temp = root;
            while (temp.left != null || temp.right != null)
            {
                if (temp.Data.Equals(data))
                {
                    return temp;
                }
                else
                {
                    //to be imlemented
                }
            }

            return root;
        }
    }

    public class BinarySearchTreeNode<T>
    {
        public T Data;
        public BinarySearchTreeNode<T> left;
        public BinarySearchTreeNode<T> right;

        public BinarySearchTreeNode(T data)
        {
            Data = data;
            left = null;
            right = null;
        }
    }
}
