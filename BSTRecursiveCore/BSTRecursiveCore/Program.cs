using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinarySearchTreeRecursive
{
    class Program
    {
        static void Main(string[] args)
        {


            // Create an instance of the BinarySearchTree();
            BinarySearchTree binarySearchTree = new BinarySearchTree();



            // insert at least 15 items(integers). Make sure you insert them in a way
            // that the numbers are not sorted. Ex: do not insert a series of numbers like 1, 2, 4, 5, 6, 9, 14,16,44,45
            // insert something that's not sorted

            Random randomRange = new Random();
            Random intSelection = new Random();
            int itemCount = randomRange.Next(15, 21);
            int itemToAdd = 0;
            
            for (int i = 0; i < itemCount; i++)
            {
                itemToAdd = intSelection.Next(0, 100);
                binarySearchTree.Insert(itemToAdd);
            }

            //call the traverse method
            binarySearchTree.Traverse();


            // call the Vsualize method
            binarySearchTree.Visualize();


        }
    }
}
