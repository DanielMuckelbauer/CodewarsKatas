using System;
using SortBinaryTree;

var tree = TreeCreator.CreateTree();

Console.WriteLine(string.Concat(BinaryTreeSorter.TreeByLevels(tree)));
Console.WriteLine(string.Concat(BinaryTreeSorterQueue.TreeByLevels(tree)));
