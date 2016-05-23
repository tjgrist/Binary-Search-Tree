using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node
    {
        public int value;
        public Node leftNode;
        public Node rightNode;

        public Node(int value)
        {
            this.value = value;
            leftNode = null;
            rightNode = null;
        }
    }
}
