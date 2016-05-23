using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Tree
    {
        public Node headNode;

        public Tree(int value)
        {
            headNode = new Node(value);
        }
        public Tree()
        {
            headNode = null;
        }

        public void AddNode(int value)
        {
            Node currentNode = headNode;
            bool isAdded = false;
            if (currentNode == null)
            {
                currentNode = new Node(value);
                return;
            }
            do
            {
                if (value <= currentNode.value)
                {
                    if (currentNode.leftNode == null)
                    {
                        currentNode.leftNode = new Node(value);
                        PrintWhereAddedLeft(currentNode);
                        isAdded = true;
                    }
                    else { currentNode = currentNode.leftNode; }
                }
                
                else if (value >= currentNode.value)
                {
                    if (currentNode.rightNode == null)
                    {
                        currentNode.rightNode = new Node(value);
                        PrintWhereAddedRight(currentNode);
                        isAdded = true;
                    }
                    else { currentNode = currentNode.rightNode; }
                }

            } while (!isAdded);
            Console.WriteLine(isAdded);
        }

        public void FindNode(int value)
        {
            bool found = false;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Node searchNode = headNode;
            if (value == searchNode.value)
            {
                Console.WriteLine("Found at HeadNode!");
            }
            do
            {
                if (value < searchNode.value)
                {
                    searchNode = searchNode.leftNode;
                    if (searchNode.value == value)
                    { Console.Write("Found {0} to the left of {1}.",value, searchNode.leftNode.value); }
                }
                else if (value > searchNode.value)
                {
                    searchNode = searchNode.rightNode;
                    if (searchNode.value == value)
                    { Console.Write("Found {0} to the right of {1}.", value, searchNode.rightNode.value); }
                }
            } while (!found);
                         
            Console.Write("Time: " + stopwatch.Elapsed);
        }

        private void PrintWhereAddedLeft(Node node)
        {
            Console.WriteLine("Added {0} to the left of {1}", node.leftNode.value, node.value);
        }
        private void PrintWhereAddedRight(Node node)
        {
            Console.WriteLine("Added {0} to the right of {1}", node.rightNode.value, node.value);
        }
    }
}
