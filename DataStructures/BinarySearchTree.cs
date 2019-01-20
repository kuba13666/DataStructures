using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode root;

        public BinarySearchTreeNode SearchForANode(BinarySearchTreeNode tempRoot, int data)
        {
            if (tempRoot== null || tempRoot.Data == data)
            {
                return tempRoot;
            }
            return data>root.Data ? SearchForANode(tempRoot.right, data) : SearchForANode(tempRoot.left, data);
        }

        public void Insert(int data)
        {
            root = InsertRec(root, data);
        }

        public void Delete(int data)
        {
            if (root == null)
            {
                return;
            }

            if (root.Data == data)
            {
                root = null;
            }

            if (data > root.Data)
            {
                root.right = InsertRec(root.right, data);
            }
            if (data < root.Data)
            {
                root.left = InsertRec(root.left, data);
            }

            //return root;
        }
        public BinarySearchTreeNode InsertRec(BinarySearchTreeNode root, int data)
        {
            if (root == null)
            {
                root = new BinarySearchTreeNode(data);
                return root;
            }

            if (data > root.Data)
            {
                root.right = InsertRec(root.right, data);
            }
            if (data < root.Data)
            {
                root.left = InsertRec(root.left, data);
            }
            return root;
        }

        public BinarySearchTreeNode Max(BinarySearchTreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            if (root.right!=null)
            {
                return Max(root.right);
            }
            return root;
        }

        public BinarySearchTreeNode Min(BinarySearchTreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            if (root.left != null)
            {
                return Min(root.left);
            }
            return root;
        }


        public int Height(BinarySearchTreeNode root, int counter, int max)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left != null)
            {
                counter++;
                max = Height(root.left, counter, max);
                counter--;
            }

            if (root.right != null)
            {
                counter++;
                max = Height(root.right, counter, max);
                counter--;
            }
            if (max<counter)
            {
                max = counter;
            }

            return max;
        }

        public void TraverseInorder(BinarySearchTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            if (root.left != null)
            {
                TraverseInorder(root.left);
            }
            Console.WriteLine(root.Data);
            if (root.right != null)
            {
                TraverseInorder(root.right);
            }
        }
    }



    public class BinarySearchTreeNode
    {
        public int Data;
        public BinarySearchTreeNode left;
        public BinarySearchTreeNode right;

        public BinarySearchTreeNode(int data)
        {
            Data = data;
            left = null;
            right = null;
        }
    }
}
