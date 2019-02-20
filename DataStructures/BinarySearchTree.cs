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

        public BinarySearchTreeNode InorderSuccessor(BinarySearchTreeNode root, int data)
        {
            if (root==null)
            {
                return null;
            }

            if (data < root.Data)
            {
                var temp = InorderSuccessor(root.left, data);
                if (temp!=null)
                {
                    return temp;
                }
                //tu chyba bedzie ze jezeli temp= null to min z prawego
                return root;
            }
            else if (data > root.Data)
            {
                var temp = InorderSuccessor(root.right, data);
                if (temp != null)
                {
                    return temp;
                }
                //tu chyba bedzie ze jezeli temp= null to min z prawego
            }
            else
            {
                if (root.right!=null)
                {
                    return Min(root.right);
                }
            }
            return null;
        }

        public BinarySearchTreeNode Delete(BinarySearchTreeNode root, int data)
        {
            if (root==null)
            {
                return null;
            }
            if (data<root.Data)
            {
                Delete(root.left, data);
            }
            else if(data > root.Data)
            {
                Delete(root.right, data);
            }
            else
            {
                if (root.left == null && root.right == null)
                {
                    root = null;
                    return root;
                }

                if (root.left != null && root.right == null)
                {
                    root = root.left;
                    return root;
                }
                else if (root.left != null && root.right == null)
                {
                    root = root.right;
                    return root;
                }

                if (root.left != null && root.right != null)
                {
                    var replacementNode = Min(root.right);
                    root.Data = replacementNode.Data;
                    root.right = Delete(replacementNode, replacementNode.Data);
                }
            }
            return root;
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

        public bool IsBSTUtil(BinarySearchTreeNode root, int max, int min)
        {
            if (root == null)
            {
                return true;
            }

            if (root.Data < min || root.Data > max)
            {
                return false;
            }

            return IsBSTUtil(root.left, root.Data, int.MinValue) && IsBSTUtil(root.right, int.MaxValue, root.Data);
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
