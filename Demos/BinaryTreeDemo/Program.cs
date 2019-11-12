using System;
using System.Collections;

namespace BinaryTreeDemo
{
   
    class Program
    {
        class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public int Data { get; set; }
        }

        class BinaryTree
        {
            public Node Root { get; set; }

            public bool Add(int value)
            {

                Node newNode = new Node();
                newNode.Data = value;

                if (this.Root == null)//Tree is empty
                {
                    this.Root = newNode;//New root node
                }
                else
                {
                    Node after = this.Root;
                    Node before;

                    while (true)
                    {
                        before = after;//before copys the root data
                        if (value < after.Data)//if value is less than the root
                        {
                            after = after.LeftNode;//move pointer to the left
                            if (after == null)//if after points to nothing
                            {
                                before.LeftNode = newNode;//add new node containing value to the left
                                break;
                            }
                        }
                        else
                        {
                            after = after.RightNode;//move pointer to the right
                            if (after == null)//if after points to nothing
                            {
                                before.RightNode = newNode;//add new node containing value to the right
                                break;
                            }
                        }
                    }
                }

                return true;
            }

            public Node Find(int value)
            {
                return this.Find(value, this.Root);
            }

            public void Remove(int value)
            {
                Remove(this.Root, value);
            }

            private Node Remove(Node parent, int key)
            {
                if (parent == null)
                {
                    return parent;
                }

                if (key < parent.Data)
                {
                    parent.LeftNode = Remove(parent.LeftNode, key);
                }
                else if (key > parent.Data)
                {
                    parent.RightNode = Remove(parent.RightNode, key);
                }
                else//if value is the same as parents value, then this is the node to be deleted
                {
                    //node with only one or no child
                    if (parent.LeftNode == null)
                    {
                        return parent.RightNode;
                    }
                    else if (parent.RightNode == null)
                    {
                        return parent.LeftNode;
                    }

                    //node with 2 children: Get the inorder successor(smallest in the right subtree)
                    parent.Data = MinValue(parent.RightNode);

                    //delete the  inoder successor
                    parent.RightNode = Remove(parent.RightNode, parent.Data);
                }

                return parent;
            }

            private int MinValue(Node node)
            {
                int minv = node.Data;

                while (node.LeftNode != null)
                {
                    minv = node.LeftNode.Data;
                    node = node.LeftNode;
                }

                return minv;
            }

            private Node Find(int value, Node parent)
            {
                if (parent != null)
                {
                    if (value == parent.Data)
                    {
                        return parent;
                    }

                    if (value < parent.Data)
                    {
                        return Find(value, parent.LeftNode);
                    }
                    else
                    {
                        return Find(value, parent.RightNode);
                    }
                }
                return null;
            }

            public void TraverseInOrder(Node parent)
            {
                if (parent != null)
                {
                    TraverseInOrder(parent.LeftNode);
                    Console.Write(parent.Data + " ");
                    TraverseInOrder(parent.RightNode);
                }
            }

        }
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(5);

            Console.WriteLine("InOrder Traversal: ");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("InOrder Traversal After Removing: ");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
