using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static Tree bsTree = new Tree(15);
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] ints = new int[] { 7, 3, 5, 6, 8, 9, 2, 1, 4, 11, 23, 24, 15, 18, 17, 16, 19, 20, 25, 21, 22 };
            foreach(int i in ints)
            {
                bsTree.AddNode(i);
            }
            bsTree.FindNode(ints.ElementAt(r.Next(0, ints.Count())));

            Console.ReadKey();
        }
    }
}
