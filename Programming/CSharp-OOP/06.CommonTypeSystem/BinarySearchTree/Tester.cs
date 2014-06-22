// 06. * Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". 
// It is not necessary to keep the tree balanced. 
// Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison  == and !=. 
// Add and implement the ICloneable interface for deep copy of the tree. Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). 
// Implement IEnumerable<T> to traverse the tree.
namespace BinarySearchTree
{
    using System;

    internal class Tester
    {
        public static void Main()
        {
            BinarySearchTree<int> tree1 = new BinarySearchTree<int>();

            tree1.AddElement(10);
            tree1.AddElement(5);
            tree1.AddElement(15);
            tree1.AddElement(6);
            tree1.AddElement(4);
            tree1.AddElement(16);
            tree1.AddElement(14);
            tree1.AddElement(19);

            Console.WriteLine(tree1);

            foreach (var item in tree1)
            {
                Console.WriteLine(item);
            }

            var copy = tree1.Clone();

            Console.WriteLine(copy);

            Console.WriteLine(tree1.FindElement(17));

            Console.WriteLine(tree1.FindElement(16));

            tree1.RemoveElement(19);

            Console.WriteLine(tree1);
        }
    }
}